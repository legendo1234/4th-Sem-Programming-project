using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopService.Transporter;
using System.Collections.Generic;

namespace UnitTesting.Service
{
    [TestClass]
    public class Category
    {
        public CategoryRef.ICategory categoryRef;
        public CategoryRef.TCategory cat;
        public List<CategoryRef.TCategory> cats;

        [TestInitialize]
        public void Init()
        {
            categoryRef = new CategoryRef.CategoryClient();
            cat = new CategoryRef.TCategory();
            cats = new List<CategoryRef.TCategory>();
        }

        [TestMethod]
        public void CategoryServiceCreate()
        {
            cat = new CategoryRef.TCategory { name = "test category" };
            Assert.IsTrue(categoryRef.Create(cat), "Error creating category");
        }

        [TestMethod]
        public void CategoryServiceRead()
        {
            Assert.IsTrue(categoryRef.Read(1).name == "Mouse");
        }

        [TestMethod]
        public void CategoryServiceReadAll()
        {
            cats = new List<CategoryRef.TCategory>(categoryRef.ReadAll());
            Assert.IsNotNull(cats, "The list returned is null");
            cat = cats[cats.Count - 1];
        }

        [TestMethod]
        public void CategoryServiceUpdate()
        {
            cats = new List<CategoryRef.TCategory>(categoryRef.ReadAll());
            cat = cats[0];
            cat.name = "New name";
            Assert.IsTrue(categoryRef.Update(cat));
            Assert.IsTrue(categoryRef.Read(1).name == "New name");
            cat.name = "Mouse";
            cat.timestamp++;
            Assert.IsTrue(categoryRef.Update(cat));
            Assert.IsTrue(categoryRef.Read(1).name == "Mouse");
        }

        [TestMethod]
        public void CategoryServiceDelete()
        {
            cats = new List<CategoryRef.TCategory>(categoryRef.ReadAll());
            cat = cats[cats.Count - 1];
            Assert.IsTrue(categoryRef.Delete(cat), "Error deleting category");
        }
    }
}
