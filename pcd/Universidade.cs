using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcd
{
    class Universidade : Observer
    {
        private string _nome;
        private List<string> _interesses;

        public Universidade(string nome, List<string> interesses)
        {
            _nome = nome;
            _interesses = interesses;
        }


        //Callback
        //não é a universidade que chamada esse metodo apenas o subject quando há novos dados
        public void Update(Subject s, string tipoDado)
        {
            PCDAmazonia pcd = (PCDAmazonia)s;

            if (_interesses.Contains(tipoDado))
            {
                Console.Write($"[NOTIFICAÇÃO] Destino: {_nome} | Origem: {pcd.Localizacao} -> ");

                switch (tipoDado)
                {
                    case "TEMP": Console.WriteLine($"Nova Temperatura da Água: {pcd.TempAgua}°C"); break;
                    case "PH": Console.WriteLine($"Novo pH da Água: {pcd.PhAgua}"); break;
                    case "UMIDADE": Console.WriteLine($"Nova Umidade do Ar: {pcd.UmidadeAr}%"); break;
                }
            }
        }
    }
}
