﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Locatronics;
using System.Collections.Generic;

namespace tests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void search_1N4007()
        {
            // search the basket contents
            // find the address
            // glow address rack
            organizer o = new organizer();

            int requiredAddress = 129;
            string component = "1N4007";
            List<basket> search = o.search(component);
            Assert.AreEqual(search.Count, 1);

            Assert.AreEqual(search[0].location.address, requiredAddress);
        }

        [TestMethod]
        public void search_Capacitors()
        {
            // search the basket contents
            // find the address
            // glow address rack
            organizer o = new organizer();

            int requiredAddress = 141;
            string component = "capacitor";
            List<basket> search = o.search(component);
            Assert.AreEqual(search.Count, 3);

            // 141, 142, 143
            Assert.AreEqual(search[0].location.address, requiredAddress);
        }

        [TestMethod]
        public void search_GPIO()
        {
            organizer o = new organizer();

            int requiredAddress = 175;
            string component = "GPIO";
            List<basket> search = o.search(component);

            Assert.AreEqual(search.Count, 1);
            Assert.AreEqual(search[0].location.address, requiredAddress);
        }
    }
}
