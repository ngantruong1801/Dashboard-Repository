using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_Dashboard.Common
{
    class TestData
    {
        public static string data = CommonActions.ReadData();
        public static string[] datatest = data.Split(';');
        public static string validUsername = datatest[1];
        public static string validPassword = datatest[2];
        public static string dashBoardURL = datatest[0];
        public static string browser = datatest[3];

    }
}
