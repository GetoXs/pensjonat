﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PensjonatApp.DS;
using PensjonatApp.Tools;

namespace PensjonatApp.Helpers
{
    class PokojeHelper
    {
        public static int dodajPokoj(int id_slownikowe_pokoju, string nr_pokoju)
        {
            return TablesManager.Manager.PokojeTableAdapter.Insert(id_slownikowe_pokoju, nr_pokoju);
        }

        public static int edytujPokoj(int id_pokoju, int id_slownikowe_pokoju, string nr_pokoju)
        {
            PokojeDS.PokojeDataTable doZmiany = TablesManager.Manager.PokojeTableAdapter.GetDataByID(id_pokoju);
            doZmiany[0].id_slownikowe_pokoju = id_slownikowe_pokoju;
            doZmiany[0].nr_pokoju = nr_pokoju;
            return TablesManager.Manager.PokojeTableAdapter.Update(doZmiany);
        }

        public static void usunPokoj(int id_pokoju)
        {
        }
    }
}
