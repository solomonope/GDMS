using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDataLib.BO;
using GDataLib.DAL;

namespace GDataLib.BLL
{
   public  class ReadingsManager
    {
       //ReadingsData m_ReadingsData;

       MySqlReadingsData m_ReadingsData;


       public ReadingsManager()
       {
          // m_ReadingsData = new ReadingsData();

           m_ReadingsData = new MySqlReadingsData();
       }
       public bool Upsert(Readings Reading)
       {
           try
           {
               return m_ReadingsData.Create(Reading);
           }
           catch (Exception Ew)
           {
               return false;
           }

       }

       public bool Update(Readings Reading)
       {
           try
           {
               return m_ReadingsData.Update(Reading);
           }
           catch (Exception Ew)
           {
               return false;
           }
       }

       public Readings GetById(String Id)
       {
           try
           {
               return (from n in m_ReadingsData.Read() where n.ReadingsId.ToString() == Id select n).SingleOrDefault<Readings>();
           }
           catch (Exception Ew)
           {
               return null;
           }
       }

       public Readings GetById(Guid Id)
       {
           try
           {
               return (from n in m_ReadingsData.Read() where n.ReadingsId == Id select n).SingleOrDefault<Readings>();
           }
           catch (Exception Ew)
           {
               return null;
           }
       }

       public List<Readings> GetAllReadings()
       {
           try
           {
               return m_ReadingsData.Read();
           }
           catch (Exception Ew)
           {
               return null;
           }
       }

       public bool Delete(Readings _Reading)
       {
           try
           {
               if (_Reading != null)
               {
                   m_ReadingsData.Delete(_Reading);
                   return true;
               }
               return false;
           }
           catch (Exception Ew)
           {
               return false;
           }
       }
    }
}
