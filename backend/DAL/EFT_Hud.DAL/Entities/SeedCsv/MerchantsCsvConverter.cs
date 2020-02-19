using System;
using System.Collections.Generic;
using System.Text;

namespace EFT_Hud.DAL.Entities.SeedCsv
{
    internal interface ICsvConverter<T>
    where T : class
    {
        string Filename { get; }

        string RawData { get; }

        bool HasHeaders { get; }

        ICollection<T> GetData();
    }

    

    //public class MerchantsCsvConverter : ICsvConverter<Merchant>
    //{
    //    public string Filename { get; }
    //    public string RawData { get; }
    //    public bool HasHeaders { get; }
    //    public ICollection<Merchant> GetData()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
