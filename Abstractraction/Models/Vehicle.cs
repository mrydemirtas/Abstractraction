using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    //soyut sınıf olarak geçerler 
    //bir çok somut sınıfın atasıdır
    //işin özeti hakkında bilgi sahibi olduğumuz sınıflar
    //detayı hakkında herhangi bir yorum yapamayacağımız sınıflarımız
    //abstract üyeleri olabilir.
    //abstract dışında üyeleri de olabilir.
    //abstract üyeler kalıtım alınan sub class dediğimiz alt sınıflarda kullanılmak zorundadır. (implementasyon)
    //Ornek oluşturulamaz
    public abstract class Vehicle
    {
        public abstract string FuelType { get;  }
        //method yada property özeti yazılır.Body içerik yoktur.
        //detayının method içeriğini veya property içeriğini yazamazsınız
        //abstract olmayan bir sınıfa kalıtım ile aktarırsak ovveride etmek mecburiyetindeyiz.
        public abstract string StartEngine();
        

        //aşağıdaki kullanım ovveride edilmeyi zorlamaz
        public virtual string GetEngineNumber()
        {
            return this.EngineNumber;
        }

        public string EngineNumber { get; set; }

    }
}
