using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcd
{
    class PCDAmazonia : Subject
    {
        public string Localizacao { get; }
        private double _tempAgua;
        private double _phAgua;
        private double _umidadeAr;

        public PCDAmazonia(string localizacao)
        {
            Localizacao = localizacao;
        }

        public double TempAgua
        {
            get => _tempAgua;
            set { _tempAgua = value; 
                //não chama cada universiade manualmente 
                //a responsabilidade de notificar é do subject
                NotifyObservers("TEMP"); }
        }

        public double PhAgua
        {
            get => _phAgua;
            set { _phAgua = value;
                //não chama cada universiade manualmente 
                //a responsabilidade de notificar é do subject
                NotifyObservers("PH"); }
            }

        public double UmidadeAr
        {
            get => _umidadeAr;
            set { _umidadeAr = value;
                //não chama cada universiade manualmente 
                //a responsabilidade de notificar é do subject
                NotifyObservers("UMIDADE"); }
        }
    }
}
