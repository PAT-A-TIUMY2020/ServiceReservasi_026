﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi_026
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi); //method //proses input data

        [OperationContract]
        string editPesanan(string IDPemesanan, string NamaCustomer, string No_telpon);

        [OperationContract]
        string deletePemesanan(string IDPemesanan);

        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //menampilkan data yang ada di database (select all) // menampilkan isi dari yang ada contact

        [OperationContract]
        List<DetailLokasi> DetailLokasi(); //menampilkan detail lokasi

        [OperationContract]
        List<Pemesanan> Pemesanan();

        // TODO: Add your service operations here
    }


    [DataContract]
    public class CekLokasi // daftar lokasi nongrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi // daftar lokasi nongrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiFull { get; set; }

        [DataMember]
        public int Kuota { get; set; }

    }

    [DataContract]
    public class Pemesanan // create
    {
        [DataMember]
        public string IDPemesanan { get; set; } //variabel dari public class

        [DataMember]
        public string NamaCustomer { get; set; }

        [DataMember]
        public string NoTelpon { get; set; }

        [DataMember]
        public int JumlahPemesanan { get; set; }

        [DataMember]
        public string Lokasi { get; set; }

    }
}
