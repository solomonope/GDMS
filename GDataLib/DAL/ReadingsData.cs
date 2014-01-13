using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDataLib.BO;
using Db4objects.Db4o;

namespace GDataLib.DAL
{
    class ReadingsData
    {
        public Boolean Create(Readings Reading)
        {
            try
            {
                using (var _Db = Db4oFactory.OpenFile(Config.ConnString))
                {
                    _Db.Store(Reading);
                    _Db.Commit();
                }
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
        }

        public List<Readings> Read()
        {
            try
            {
                using (var _Db = Db4oFactory.OpenFile(Config.ConnString))
                {
                    return new List<Readings>(_Db.Query<Readings>(typeof(Readings)).ToArray<Readings>());
                  
                }
            }
            catch (Exception Ew)
            {
                return null;
            }
        }


        public bool Update(Readings Reading)
        {
            try
            {
                using (var _Db = Db4oFactory.OpenFile(Config.ConnString))
                {
                    _Db.Store(Reading);
                    _Db.Commit();
                }
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
        }


        public bool Delete(Readings Reading)
        {
            try
            {
                using (var _Db = Db4oFactory.OpenFile(Config.ConnString))
                {
                    _Db.Delete(Reading);
                    _Db.Commit();
                }
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
        }
    }
}
