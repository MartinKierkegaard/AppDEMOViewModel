using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDEMOViewModel
{

    public class KlasserumViewModel
    {
        public ObservableCollection<KlasseRum> OC_KlasseRum { get; set; }
       
        public KlasserumViewModel()
        {
            OC_KlasseRum = new ObservableCollection<KlasseRum>();
            OC_KlasseRum.Add(new KlasseRum() { Navn = "KL1", ID = 1 });
            OC_KlasseRum.Add(new KlasseRum() { Navn = "KL2", ID = 2 });
            OC_KlasseRum.Add(new KlasseRum() { Navn = "KL3", ID = 3 });
            OC_KlasseRum.Add(new KlasseRum() { Navn = "KL4", ID = 4 });


        }

    }
}
