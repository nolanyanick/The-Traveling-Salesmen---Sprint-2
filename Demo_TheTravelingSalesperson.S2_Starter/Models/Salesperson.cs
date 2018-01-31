﻿using System.Collections.Generic;

namespace Demo_TheTravelingSalesperson
{
    /// <summary>
    /// Salesperson MVC Model class
    /// </summary>
    public class Salesperson
    {
        #region FIELDS

        private string _firstName;
        private string _lastName;
        private string _accountID;
        private string _startingCity;
        private List<string> _citiesVisited;
        private List<Product.ProductType> _productList;    
        private Product _currentStock;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public string StartingCity
        {
            get { return _startingCity; }
            set { _startingCity = value; }
        }

        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }

        public Product CurrentStock
        {
            get { return _currentStock; }
            set { _currentStock = value; }
        }

        public List<Product.ProductType> ProductList
        {
            get { return _productList; }
            set { _productList = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Salesperson()
        {
            _citiesVisited = new List<string>();
            _currentStock = new Product();
            _productList = new List<Product.ProductType>();
        }

        public Salesperson(string firstName, string lastName, string acountID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountID = acountID;

            _citiesVisited = new List<string>();
            _currentStock = new Product();
            _productList = new List<Product.ProductType>();
        }

        #endregion

        #region METHODS



        #endregion
    }
}
