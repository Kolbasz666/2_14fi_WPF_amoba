﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_14fi_WPF_masodik
{
    class Data
    {
        public static ObservableCollection<JsonResponse> users = new ObservableCollection<JsonResponse>()
                                                            { new JsonResponse(), new JsonResponse() };
    }
}
