﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viper.DesktopApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Establecer resolucion de la ventana
            int height = Screen.PrimaryScreen.Bounds.Height; //Obtiene el alto de la pantalla principal en pixeles.
            int width = Screen.PrimaryScreen.Bounds.Width; //Obtiene el ancho de la pantalla principal en pixeles.

            if (width < 1680 && height <= 1080)
            {
                MessageBox.Show(new Form { TopMost = true }, "La resolucion de la computadora no es compatible con el Sistema Viper\nFavor de colocar la resolucion minima de 1680 x 1080", "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
                String connectionName = String.Empty;

                if (connections.Count != 0)
                {
                    foreach (ConnectionStringSettings connection in connections)
                    {
                        connectionName = connection.Name;
                    }
                }

                string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show(new Form { TopMost = true }, "La cadena de conexion no ha sido configurada", "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.Open();
                        Console.WriteLine("MySQL version: " + connection.ServerVersion);
                        connection.Close();

                        BusinessLogicLayer.MenuBLL.procUploadPermissionsToMenuByAdministrator();
                        BusinessLogicLayer.MenuBLL.procUploadPermissionsToMenuByBasic();

                        bool isExistsCompany = false;

                        isExistsCompany = BusinessLogicLayer.CompanyBLL.procIsCompanyRegistered();

                        if (isExistsCompany)
                        {
                            Application.Run(new frmLogin());
                        }
                        else
                        {
                            Application.Run(new frmRegisterCompany(true));
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            using (BusinessEntities.ViperDbContext dbCtx = new BusinessEntities.ViperDbContext())
                            {
                                bool isDataBaseExist = Database.Exists(dbCtx.Database.Connection);

                                if (isDataBaseExist)
                                {
                                    MessageBox.Show(new Form { TopMost = true }, ex.Message, "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Thread t = new Thread(new ThreadStart(startForm));
                                    t.Start();
                                    Thread.Sleep(45000);
                                    t.Abort();
                                    BusinessLogicLayer.MenuBLL.procUploadPermissionsToMenuByAdministrator();
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(new Form { TopMost = true }, ex1.Message, "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private static void startForm()
        {
            Application.Run(new frmUploadDataToDataBase());
        }
    }
}
