using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopController;
using ShopModel;
using System.Collections.Generic;

namespace UnitTesting.Controller
{
    [TestClass]
    public class Category
    {
        public ShopModel.Category cat;
        public List<ShopModel.Category> cats;
        public CategoryController ctrl;

        [TestInitialize]
        public void Init()
        {
            cat = new ShopModel.Category { Name = "test controller category" };
            cats = new List<ShopModel.Category>();
            ctrl = new CategoryController();
        }

        [TestMethod]
        public void CategoryCtrlCreate()
        {
            Assert.IsTrue(ctrl.Create(cat));
        }

        [TestMethod]
        public void CategoryCtrlRead()
        {
            Assert.IsTrue(ctrl.Read(1).Name == "Mouse");
        }

        [TestMethod]
        public void CategoryCtrlReadAll()
        {
            cats = ctrl.ReadAll();
            Assert.IsNotNull(cats);
        }

        [TestMethod]
        public void CategoryCtrlUpdate()
        {
            cats = ctrl.ReadAll();
            cat = cats[0];
            cat.Name = "New name";
            Assert.IsTrue(ctrl.Update(cat));
            Assert.IsTrue(ctrl.Read(1).Name == cat.Name);
            cat.Name = "Mouse";
            Assert.IsTrue(ctrl.Update(cat));
            Assert.IsTrue(ctrl.Read(1).Name == "Mouse");
        }

        [TestMethod]
        public void CategoryCtrlDelete()
        {
            cats = ctrl.ReadAll();
            cat = cats.Find(x => x.Name == cat.Name);
            Assert.IsTrue(ctrl.Delete(cat));
        }
    }
}
