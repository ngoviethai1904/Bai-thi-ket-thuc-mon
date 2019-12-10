using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace webtintuc.Models
{
    public class tintucDatabaseInitializer : DropCreateDatabaseAlways<tintucContext>
    {
        protected override void Seed(tintucContext context)
        {
            GetCategories().ForEach(c => context.tacgia.Add(c));
            Gettintuc().ForEach(p => context.tintucs.Add(p));
        }
        private static List<tacgia> GetCategories()
        {
            var tacgia = new List<tacgia> {
                    new tacgia
                        {
                            tacgiaID = 1,
                            TenTG = "Đài truyền hình Việt Nam",
                            Email = "thvn@gmail.com"
                        },
                    new tacgia
                        {
                            tacgiaID = 2,
                            TenTG = "Truyền hình kỹ thuật số VTC",
                            Email ="vtc@gmail.com"
                        },
                    new tacgia{
                            tacgiaID= 3,
                            TenTG  = "Truyền hình cáp",
                            Email = "thcap@gmail.com"
                        },
                    new tacgia
                        {
                            tacgiaID = 4,
                            TenTG  = "Đài tiếng nói Việt Nam",
                            Email = "tnvn@gmail.com"
                        }
                    };
            return tacgia;
        }
        private static List<tintuc> Gettintuc()
        {
            var tintucs = new List<tintuc>
            {

                new tintuc
                    {
                        TinID = 1,
                        Noidung = "Chinhtri",
                        Ngaygui = "12/10/2019",
                        Anh = "Pic1.png",                        
                        tacgiaID = 1
                    },
                new tintuc
                    {
                        TinID = 2,
                        Noidung = "Kinh tế",
                        Ngaygui= "11/09/2019",
                        Anh = "pic2.jpg",
                        tacgiaID = 2
                    },
                new tintuc
                    {
                        TinID = 3,
                       Noidung = "Văn hóa",
                        Ngaygui= "3/2/2019",
                        Anh = "pic3.jpg",
                        tacgiaID = 2
                    },
                new tintuc
                    {
                        TinID = 4,
                       Noidung = "Xã hội",
                       Ngaygui= "9/8/2019",
                        Anh = "pic4.jfif",
                        tacgiaID = 3
                    },
                new tintuc
                    {
                        TinID = 5,
                        Noidung = "Giao dục",
                        Ngaygui = "7/9/2019",
                        Anh = "pic5.jpg",
                        tacgiaID = 4
                    },
            };
            return tintucs;
        }
    }
}