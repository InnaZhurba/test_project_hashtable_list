using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace lab2mod2_testing
{
    [TestClass]
    public class list_test
    {
        [TestMethod]
        public void Add_pass_equal_test()
        {
            List<int> test_data = new List<int> { };
            List<int> true_data = new List<int> { 1 };

            test_data.Add(1);

            CollectionAssert.AreEqual(test_data,true_data);
        }

        [TestMethod]
        public void Add_fail_not_equal_test()
        {
            List<int> test_data = new List<int> { };
            List<int> true_data = new List<int> { 1 };

            test_data.Add(5);

            CollectionAssert.AreNotEqual(test_data, true_data);
        }

        [TestMethod]
        public void Add_Range_fail_argumentnullex_test()
        {
            List<int> test_data = new List<int> { };
            List<int> true_data = new List<int> { 1 };
            try
            {
                test_data.AddRange(null);
                Assert.Fail();
            }
            catch(Exception){}
        }

        [TestMethod]
        public void Add_Range_pass_equal_test()
        {
            List<int> test_data = new List<int> { 1};
            List<int> true_data = new List<int> { 1, { 21 } };

            List<int> data = new List<int>{ 21};

            test_data.AddRange(data);

            CollectionAssert.AreEqual(test_data, true_data);
        }

        [TestMethod]
        public void As_Read_Only_pass_change_data_test()
        {
            IList<int> test_data;
            List<int> true_data = new List<int> { 1, 21 };

            test_data = true_data.AsReadOnly();

            true_data[1] = 9;

            CollectionAssert.AreEqual((System.Collections.ICollection)test_data, true_data);
        }

        [TestMethod]
        public void As_Read_Only_fail_change_data_test()
        {
            try
            {
                IList<int> test_data;
                List<int> true_data = new List<int> { 1, 21 };

                test_data = true_data.AsReadOnly();

                test_data[1] = 9;

                Assert.Fail();
            }
            catch (Exception) { }

        }
    }
}
