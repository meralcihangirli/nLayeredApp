using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class BusinessProblemDetails : ProblemDetails //rfs dedigimz standartlar
    {//özel alan olusturmak ıcın orn valıdatıondakı hataların donus detaylarını ayarlamk ıcın
        public BusinessProblemDetails(string detail) 
        {  Title = "Rule Violation"; //kural hatası
            Detail = detail; //bızım hata bılgı
            Status = StatusCodes.Status400BadRequest; //bad req hatas
            Type = "https://example.com/probs/business"; //bu hatayı dokumen ettıgın nokta
        }
    }
}
