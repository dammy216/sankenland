using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendinbgSystem.Model.Manager
{
    public class SalesManager
    {
        private static SalesManager _instance;

        private SalesManager()
        {
        }

        public static SalesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SalesManager();
                return _instance;
            }
            return _instance;
        }
    }
}
