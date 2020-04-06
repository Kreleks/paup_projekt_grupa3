using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezba02.Models
{
    public class StudentiDB
    {
       
        private static List<Student> lista = new List<Student>();
        private static bool listaInicijalizirana = false;

        
        public StudentiDB()
        {
                   
            if (listaInicijalizirana == false) {

              

                listaInicijalizirana = true;
                
               
                lista.Add(new Student()
                {
                    Id = 1,
                    Prezime = "Ivić",
                    Ime = "Petar",
                    DatumRodjenja = new DateTime(1995, 10, 15),
                    Spol = "M",
                    GodinaStudija = GodinaStudija.Prva,
                    Oib = "12345678911",
                    RedovanStudent = true
                }
                 );

 
                lista.Add(new Student()
                {
                    Id = 2,
                    Prezime = "Mat",
                    Ime = "Milivoj",
                    DatumRodjenja = new DateTime(1958, 10, 02),
                    Spol = "M",
                    GodinaStudija = GodinaStudija.Prva,
                    Oib = "12355678912",
                    RedovanStudent = false
                }
                 );


                lista.Add(new Student()
                {
                    Id = 3,
                    Prezime = "Bes",
                    Ime = "Marta",
                    DatumRodjenja = new DateTime(2000, 01, 02),
                    Spol = "Z",
                    GodinaStudija = GodinaStudija.Treca,
                    Oib = "12355678939",
                    RedovanStudent = true
                }
                 );

                lista.Add(new Student()
                {
                    Id = 4,
                    Prezime = "Preko",
                    Ime = "Mia",
                    DatumRodjenja = new DateTime(2002, 01, 02),
                    Spol = "Z",
                    GodinaStudija = GodinaStudija.Druga,
                    Oib = "36455678939",
                    RedovanStudent = true
                }
                );
            }
        }


  
        public List<Student> VratiListu()
        {
            return lista;
        }

        public void AzurirajStudenta(Student student)
        {

            int studentIndex = lista.FindIndex(x => x.Id == student.Id);

            lista[studentIndex] = student;
        } 
    }
}