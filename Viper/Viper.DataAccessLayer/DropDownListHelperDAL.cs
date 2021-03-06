﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viper.BusinessEntities;

namespace Viper.DataAccessLayer
{
    public class DropDownListHelperDAL
    {
        #region GetGendersDropDownList

        // <summary>
        // Metodo para obtener el sexo de una persona
        // </summary>
        // <returns>List</returns>
        public static List<Gender> GetGendersDropDownList()
        {
            List<Gender> items = new List<Gender>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Genders.ToList();
                items.Add(new Gender { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetMaritalStatusDropDownList

        /// <summary>
        /// Metodo para obtener el estado civil de una persona
        /// </summary>
        /// <returns>List</returns>
        public static List<MaritalStatus> GetMaritalStatusDropDownList()
        {
            List<MaritalStatus> items = new List<MaritalStatus>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.MaritalsStatus.ToList();
                items.Add(new MaritalStatus { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetAddressTypeDropDownList

        /// <summary>
        /// Metodo para obtener los tipos de domicilio
        /// </summary>
        /// <returns>List</returns>
        public static List<AddressType> GetAddressTypeDropDownList()
        {
            List<AddressType> items = new List<AddressType>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.AddressesType.ToList();
                items.Add(new AddressType { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetRoadTypeDropDownList

        /// <summary>
        /// Metodo para obtener los tipos de vialidad
        /// </summary>
        /// <returns>List</returns>
        public static List<RoadType> GetRoadTypeDropDownList()
        {
            List<RoadType> items = new List<RoadType>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.RoadsType.ToList();
                items.Add(new RoadType { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetRolesDropDownList

        /// <summary>
        /// Metodo para obtener los roles para los usuarios
        /// </summary>
        /// <returns>List</returns>
        public static List<Role> GetRolesDropDownList()
        {
            List<Role> items = new List<Role>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Roles.ToList();
                items.Add(new Role { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetDepartmentDropDownList

        /// <summary>
        /// Metodo para obtener los departamentos donde se puede desempeñar un empleado
        /// </summary>
        /// <returns>List</returns>
        public static List<Department> GetDepartmentDropDownList()
        {
            List<Department> items = new List<Department>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Departments.ToList();
                items.Add(new Department { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetShiftDropDownList

        /// <summary>
        /// Metodo para obtener los horarios en los cuales puede trabajar un empleado
        /// </summary>
        /// <returns>List</returns>
        public static List<Shift> GetShiftDropDownList()
        {
            List<Shift> items = new List<Shift>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Shifts.ToList();
                items.Add(new Shift { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetJobTitleDropDownList

        /// <summary>
        /// Metodo para obtener los puestos que puede tener un empleado
        /// </summary>
        /// <param name="DepartmentID">ID Departamento</param>
        /// <returns>List</returns>
        public static List<JobTitle> GetJobTitleDropDownList(int DepartmentID)
        {
            List<JobTitle> items = new List<JobTitle>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.JobsTitle.Where(x=>x.DepartmentId == DepartmentID).ToList();
                items.Add(new JobTitle { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetCountryRegionDropDownList

        public static List<CountryRegion> GetCountryRegionDropDownList()
        {
            List<CountryRegion> items = new List<CountryRegion>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.CountriesRegion.ToList();
                items.Add(new CountryRegion { Id = -1, Description = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetStateProvinceDropDownList

        /// <summary>
        /// Metodo para obtener los estados de Mexico
        /// </summary>
        /// <returns>List</returns>
        public static List<StateProvince> GetStateProvinceDropDownList()
        {
            List<StateProvince> items = new List<StateProvince>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.StatesProvince.ToList();
                items.Add(new StateProvince { Id = -1, Description = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetAbrevStateProvince

        /// <summary>
        /// Metodo para obtener la abreviatura del estado
        /// </summary>
        /// <param name="StateID">ID del estado</param>
        /// <returns>String</returns>
        public static String GetAbrevStateProvince(int StateID)
        {
            using (ViperDbContext db = new ViperDbContext())
            {
                var abrev = db.StatesProvince.Where(x => x.Id == StateID).FirstOrDefault().Abrev;

                return abrev;
            }
        }

        #endregion

        #region GetCityDropDownList

        /// <summary>
        /// Metodo para obtener los municipios de Mexico
        /// </summary>
        /// <param name="StateProvinceID">ID Estado</param>
        /// <returns>List</returns>
        public static List<City> GetCityDropDownList(int StateProvinceID)
        {
            List<City> items = new List<City>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Cities.Where(x => x.StateProvinceId == StateProvinceID).ToList();
                items.Add(new City { Id = -1, Description = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetCityName
        /// <summary>
        /// Metodo para obtener el nombre del municipio
        /// </summary>
        /// <param name="cityID">ID Municipio</param>
        /// <returns>List</returns>
        public static String GetCityName(int cityID)
        {
            using (ViperDbContext db = new ViperDbContext())
            {
                var abrev = db.Cities.Where(x => x.Id == cityID).FirstOrDefault().Description;

                return abrev;
            }
        }
        #endregion

        #region GetProductCategoryDropDownList

        /// <summary>
        /// Metodo para obtener las categorias a las que pueden pertenecer un producto
        /// </summary>
        /// <returns>List</returns>
        public static List<ProductCategory> GetProductCategoryDropDownList()
        {
            List<ProductCategory> items = new List<ProductCategory>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.ProductsCategory.ToList();
                items.Add(new ProductCategory { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetProductSubCategoryDropDownList

        /// <summary>
        /// Metodo para obtener las subcategorias correspondientes a una categoria
        /// </summary>
        /// <param name="ProductCategoryID">ID Categoria</param>
        /// <returns>List</returns>
        public static List<ProductSubCategory> GetProductSubCategoryDropDownList(int ProductCategoryID)
        {
            List<ProductSubCategory> items = new List<ProductSubCategory>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.ProductsSubCategory.Where(x => x.ProductCategoryId == ProductCategoryID).ToList();
                items.Add(new ProductSubCategory { Id = -1, Name = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion

        #region GetSupplierDropDownList

        /// <summary>
        /// Metodo para obtener los proveedores registrados en la base de datos
        /// </summary>
        /// <returns>List</returns>
        public static List<Supplier> GetSupplierDropDownList()
        {
            List<Supplier> items = new List<Supplier>();

            using (ViperDbContext db = new ViperDbContext())
            {
                items = db.Suppliers.ToList();
                items.Add(new Supplier { Id = -1, SupplierName = "--SELECCIONE--" });

                return items.OrderBy(x => x.Id).ToList();
            }
        }

        #endregion
    }
}
