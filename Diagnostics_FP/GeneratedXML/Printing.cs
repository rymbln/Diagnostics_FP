using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.GeneratedXML
{
    public class Printing
    {

        //        // Create a reference to a file.
        //FileInfo fi = new FileInfo("temp.txt");
        //// Actually create the file.
        //FileStream fs = fi.Create();
        //// Modify the file as required, and then close the file.
        //fs.Close();
        //// Delete the file.
        //fi.Delete();

        //     Dim sRTF, sFileName As Object
        //'Create the file for the RTF
        //Dim fso, myFile As Object
        //fso = CreateObject("Scripting.FileSystemObject")
        //sFileName = "contract_" & AlignStr(obj.intContractId.ToString, 6) & ".rtf"
        //myFile = fso.CreateTextFile(Server.MapPath(".") & "\\Reports\\" & _
        //                                sFileName, True)

        public string PrintPatientResults(objPatientResults obj)
        {
            string fileName = "contract_" + obj.SampleID.ToString() + ".rtf";
            FileInfo fso = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\\\contracts\\\\" + fileName);
            FileStream myFile = fso.Create();
            StreamWriter strWr = new StreamWriter(myFile, Encoding.GetEncoding("WINDOWS-1251"));
            string sRTF;

            // Начинаем формирование файла
            sRTF = "{\\rtf1\\ansi\\ansicpg1251\\uc1\\deff0\\stshfdbch0\\stshfloch0\\stshfhich0\\stshfbi0\\deflang1049\\deflangfe1049\\margl720\\margr720\\margt720\\margb720\\";
            strWr.WriteLine(sRTF);
            sRTF = "{\\fonttbl {\\f0\\froman Times New Roman;}{\\f1\\fswiss Arial;}{\\f2\\fmodern Verdana;}}";
            strWr.WriteLine(sRTF);

            sRTF = "{\\info{\\title Result " + obj.SampleID.ToString() + "}{\\author IAC Laboratory}}";
            strWr.WriteLine(sRTF);


            sRTF = "{\\header\\pard\\qc\\b{\\fs16\\f2 \\b Смоленская государственная медицинская академия \\b0\\par\\b Научно-исследовательский институт антимикробной химиотерапии \\b0\\par\\b Клинико-диагностическая лаборатория, тел. 45-06-13 \\b0\\par\\par\\par}}";
            strWr.WriteLine(sRTF);
            sRTF = "{\\footer\\pard\\qc\\brdrt\\brdrs\\brdrw10\\brsp100\\fs18 Страница {\\field{\\*\\fldinst PAGE}{\\fldrslt 1}} из {\\field{\\*\\fldinst NUMPAGES}{\\fldrslt 1}} \\par}";
            strWr.WriteLine(sRTF);

             // Заполнение основного блока документа

        strWr.WriteLine("\\qc\\fs20\\f2  \\b МИКРОБИОЛОГИЧЕСКОЕ ИССЛЕДОВАНИЕ № " + obj.SampleID.ToString() +  "\\b0 \\cf0");

        strWr.WriteLine("{");
        strWr.WriteLine("\\par\\par\\fs20\\f2 ");

        
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
               "\\cellx3500\\cellx9000" +
               "\\pard\\intbl\\ql\\b\\ Лечебное учреждение: \\b0\\cell" +
               "\\pard\\intbl\\ql\\ " + obj.Clinic + " \\cell" +
               "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
              "\\cellx3500\\cellx9000" +
              "\\pard\\intbl\\ql\\b\\ Врач: \\b0\\cell" +
              "\\pard\\intbl\\ql\\ " + obj.DoctorFIO + " \\cell" +
              "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
            "\\cellx3500\\cellx9000" +
            "\\pard\\intbl\\ql\\b\\ Пациент: \\b0\\cell" +
            "\\pard\\intbl\\ql\\ " + obj.PatientFIO  + " \\cell" +
            "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
            "\\cellx3500\\cellx9000" +
            "\\pard\\intbl\\ql\\b\\ Дата рождения: \\b0\\cell" +
            "\\pard\\intbl\\ql\\ " + obj.BirthDate  + " \\cell" +
            "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
          "\\cellx3500\\cellx9000" +
            "\\pard\\intbl\\ql\\b\\ Клинический материал: \\b0\\cell" +
            "\\pard\\intbl\\ql\\ " + obj.ClinicMaterial  + " \\cell" +
            "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
              "\\cellx3500\\cellx9000" +
            "\\pard\\intbl\\ql\\b\\ Дата получения материала: \\b0\\cell" +
            "\\pard\\intbl\\ql\\ " + obj.DateDeliverySample  + " \\cell" +
             "\\pard\\intbl\\row";
        strWr.WriteLine(sRTF);
        
        strWr.WriteLine("}");

            if (obj.listAnalysis.Count > 0)
            {
                strWr.WriteLine("\\par\\par\\qj\\fs20\\f2  \\b Анализы: \\b0 \\cf0");
                foreach(var itemAnalysis in obj.listAnalysis )
                {
                    strWr.WriteLine("\\par\\par\\qj\\fs18\\f2\\b " + itemAnalysis.itemMBAnalysis.MBAnalysisType.DescriptionRus + " \\b0 - " + itemAnalysis.itemMBAnalysis.MBAnalysisResult.DescriptionRus  );
                    if (itemAnalysis.listROes.Count() > 0)
                    {
                        strWr.WriteLine("\\par\\par\\qj\\fs18\\f2\\b Выделенные микроорганизмы: \\b0"  );
                        foreach (var itemRO in itemAnalysis.listROes)
                        {
                            strWr.WriteLine("\\par\\par\\qj\\fs18\\f2 " + 
                                itemRO.itemRO.OrganismType.DescriptionEng + " - " + 
                                itemRO.itemRO.BacterialLoadValue + " " + 
                                itemRO.itemRO.BacterialLoadUnit + 
                                "  (Выделен " + itemRO.itemRO.DateOfReidentify.ToString() + ") " );
                            if (itemRO.listROandClinicalTests.Count() > 0)
                            {
                                strWr.WriteLine("\\par\\par\\qj\\fs18\\f2\\b Данные клинических тестов: \\b0"  );
                                      strWr.WriteLine("{");
                                        strWr.WriteLine("\\par\\par\\fs18\\f2 ");
                     //                   sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                     //"\\cellx3500\\cellx9000" +
                     //"\\pard\\intbl\\ql\\b\\ Лечебное учреждение: \\b0\\cell" +
                     //"\\pard\\intbl\\ql\\ " + obj.Clinic + " \\cell" +
                     //"\\pard\\intbl\\row";
                                        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
               "\\cellx2500\\cellx5500\\cellx7500\\cellx9500" +
               "\\pard\\intbl\\ql\\b\\ Антибиотик \\b0\\cell" +
               "\\pard\\intbl\\ql\\b\\ Метод \\b0\\cell" +
               "\\pard\\intbl\\ql\\b\\ Значение \\b0\\cell" +
               "\\pard\\intbl\\ql\\b\\ SIR \\b0\\cell" +
               "\\pard\\intbl\\row";
                                        strWr.WriteLine(sRTF);
                                foreach(var itemROClinicTest in itemRO.listROandClinicalTests )
                                {

                                        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                                               "\\cellx2500\\cellx5500\\cellx7500\\cellx9500" +
                                               "\\pard\\intbl\\ql\\ "+itemROClinicTest.AntibioticType.DescriptionEng +" \\cell" +
                                               "\\pard\\intbl\\ql\\ "+itemROClinicTest.Method.DescriptionRus +" \\cell" +
                                               "\\pard\\intbl\\ql\\ "+itemROClinicTest.ResultValue +" \\cell" + 
                                               "\\pard\\intbl\\ql\\ "+itemROClinicTest.ResultSIR + " \\cell" + 
                                               "\\pard\\intbl\\row";
                                        strWr.WriteLine(sRTF);
                                }                           
                                        strWr.WriteLine("}");
                             }
                        }
                    }
                    else
                    {
                        strWr.WriteLine("\\par\\par\\qj\\fs18\\f2 Микроорганизмов не обнаружено."  );
                    }
                    if (itemAnalysis.listBacterioscopy.Count() > 0)
                    {
                        strWr.WriteLine("\\par\\par\\qj\\fs18\\f2\\b Данные тестов бактериоскопии: \\b0"  );
                                      strWr.WriteLine("{");
                                        strWr.WriteLine("\\par\\par\\fs18\\f2 ");
                                        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                       "\\cellx4500\\cellx6500\\cellx8500" +
                       "\\pard\\intbl\\ql\\b\\ Показатель \\b0\\cell" +
                       "\\pard\\intbl\\ql\\b\\ Поле зрения \\b0\\cell" +
                       "\\pard\\intbl\\ql\\b\\ Значение \\b0\\cell" +
                       "\\pard\\intbl\\row";
                                        strWr.WriteLine(sRTF);
                        foreach (var itemBac in itemAnalysis.listBacterioscopy )
                        {
                            

                                        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                                               "\\cellx4500\\cellx6500\\cellx8500" +
                                               "\\pard\\intbl\\ql\\ "+ itemBac.MBBacterioscopyOrganismType.DescriptionRus  +" \\cell" +
                                               "\\pard\\intbl\\ql\\ "+ itemBac.ViewField  +"\\cell" +
                                               "\\pard\\intbl\\ql\\ "+ itemBac.Value  +" \\cell" + 
                                               "\\pard\\intbl\\row";
                                        strWr.WriteLine(sRTF);
                            
                        }
                        strWr.WriteLine("}");
                    }
                }
            }
            else
            {
            }


             strWr.WriteLine("{\\par\\par\\par\\par\\fs18\\f2 ");
        sRTF = "\\trowd\\trhdr\\trgaph30\\trleft0\\trrh262" +
                "\\cellx2000\\cellx4000\\cellx6500\\cellx9500" +
                "\\pard\\intbl\\ql\\ Зав. лабораторией:  \\cell" +
                "\\pard\\intbl\\qc\\ ___________________ \\cell" +
            "\\pard\\intbl\\qc\\ Сухорукова М.В. \\cell" +
                "\\pard\\intbl\\ql\\ Дата: " + DateTime.Now.ToString() + " \\cell" +
                "\\pard\\intbl\\row}";
        strWr.WriteLine(sRTF);
            // Завершаем формирование файла     
            sRTF = "}";
            strWr.WriteLine(sRTF);


            // Закрываем сесию
            strWr.Close();
            myFile.Close();
            return AppDomain.CurrentDomain.BaseDirectory + "\\\\contracts\\\\" + fileName;

            return "";
        }

        public string PrintReport(IEnumerable<vwTotalInfoForReport> obj)
        {
            string fileName = "Report_" + DateTime.Now.ToString().Replace(':', '_') + ".xls";
            FileInfo fso = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\\\Reports\\\\" + fileName);
            FileStream myFile = fso.Create();
            StreamWriter strWr = new StreamWriter(myFile, Encoding.GetEncoding("WINDOWS-1251"));
            string sRTF;

            sRTF = "<html><body><table>";
            strWr.WriteLine(sRTF);

            sRTF = "<tr>" + "<td>Номер образца<\\td>" +
                        "<td>ФИО Пациента<\\td>" +
                        "<td>Дата рождения<\\td>" +
                        "<td>Пол<\\td>" +
                        "<td>Контракт<\\td>" +
                        "<td>ЛПУ<\\td>" +
                        "<td>ФИО Доктора<\\td>" +
                        "<td>Клинический материал<\\td>" +
                            "<td>Тип анализа<\\td>" +
                            "<td>Статус<\\td>" +
                            "<td>Результат<\\td>" +
                            "<td>Стоимость<\\td>" + "<\\tr>";
            strWr.WriteLine(sRTF);
            int cnt = 0;
            int cntSamples = 0;
            int prevSample = 0;
            int totalSum = 0;
            foreach (var item in obj)
            {
                cnt++;
                sRTF = "<tr>";
                strWr.WriteLine(sRTF);
                int Price = (int)item.Price;
                totalSum += Price;
                if (item.SampleID != prevSample)
                {
                    cntSamples++;
                    prevSample = item.SampleID;
                }
                sRTF = "<td>" + item.SampleID.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.PatientLastname.ToString() + " " + item.PatientInitials.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.Birthdate.ToShortDateString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.Sex.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.ContractDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.ClinicGroupDesc.ToString() + " - " + item.ClinicDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.DoctorLastname.ToString() + " " + item.DoctorInitials.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.ClinicMaterialDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.MBAnalysisTypeDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.MBSatatusDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + item.MBAnalysisResultDesc.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<td>" + Price.ToString() + "<\\td>";
                strWr.WriteLine(sRTF);
                sRTF = "<\\tr>";
                strWr.WriteLine(sRTF);
            }
            sRTF = "<tr><\\tr><tr><td>" + "Итого " + "<\\td><\\tr>" +
                "<tr><td>" + "Принято образцов: " + cntSamples.ToString() + "<\\td><\\tr>" +
                "<tr><td>" + "Сделано анализов: " + cnt.ToString() + "<\\td><\\tr>" +
                "<tr><td>" + "На общую сумму: " + totalSum.ToString() + "руб.<\\td><\\tr>";
            strWr.WriteLine(sRTF);

            sRTF = "<\\table><\\body><\\html>";
            strWr.WriteLine(sRTF);

            strWr.Close();
            myFile.Close();
            return AppDomain.CurrentDomain.BaseDirectory + "\\\\Reports\\\\" + fileName;

        }


        public string PrintContractForPatient(objPatientContract obj)
        {
            string fileName = "contract_" + obj.SampleID.ToString() + ".rtf";
            FileInfo fso = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\\\contracts\\\\" + fileName);
            FileStream myFile = fso.Create();
            StreamWriter strWr = new StreamWriter(myFile, Encoding.GetEncoding("WINDOWS-1251"));
            string sRTF;

            sRTF = "{\\rtf1\\ansi\\ansicpg1251\\uc1\\deff0\\stshfdbch0\\stshfloch0\\stshfhich0\\stshfbi0\\deflang1049\\deflangfe1049\\margl720\\margr720\\margt720\\margb720\\";
            strWr.WriteLine(sRTF);
            sRTF = "{\\fonttbl {\\f0\\froman Times New Roman;}{\\f1\\fswiss Arial;}{\\f2\\fmodern Verdana;}}";
            strWr.WriteLine(sRTF);

            sRTF = "{\\info{\\title Contract " + obj.SampleID.ToString() + "}{\\author IAC Laboratory}}";
            strWr.WriteLine(sRTF);


            sRTF = "{\\header\\pard\\qc\\b{\\fs16\\f2 \\b Смоленская государственная медицинская академия \\b0\\par\\b Научно-исследовательский институт антимикробной химиотерапии \\b0\\par\\b Клинико-диагностическая лаборатория, тел. 45-06-13 \\b0\\par\\par\\par}}";
            strWr.WriteLine(sRTF);
            sRTF = "{\\footer\\pard\\qc\\brdrt\\brdrs\\brdrw10\\brsp100\\fs18 Страница {\\field{\\*\\fldinst PAGE}{\\fldrslt 1}} из {\\field{\\*\\fldinst NUMPAGES}{\\fldrslt 1}} \\par}";
            strWr.WriteLine(sRTF);
            sRTF = "\\qc\\fs20\\f0\\b ДОГОВОР № " + obj.SampleID.ToString() + "\\b0\\cf0";
            strWr.WriteLine(sRTF);
            sRTF = "\\line\\bНА ОКАЗАНИЕ МЕДИЦИНСКИХ УСЛУГ \\b0\\cf0";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("{");
            strWr.WriteLine("\\par\\par\\fs20\\f0 ");

            sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262\\cellx5000\\cellx10500" +
                   "\\pard\\intbl\\ql\\b\\ г.Смоленск \\b0\\cell" +
                   "\\pard\\intbl\\qr\\b\\ " + DateTime.Now.ToShortDateString() + " г. \\b0\\cell" +
                   "\\pard\\intbl\\row";
            strWr.WriteLine(sRTF);
            strWr.WriteLine("}");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\bГосударственное бюджетное образовательное учреждение высшего профессионального образования «Смоленская государственная медицинская академия» " +
                    "Министерства  здравоохранения Российской Федерации (ГБОУ ВПО СГМА Минздрава России), \\b0 в дальнейшем \\b«Исполнитель»\\b0, в лице директора НИИАХ Козлова Романа Сергеевича, " +
                    "действующего на основании Доверенности № 31 от 9 января 2013 г. и лицензий № ФС-67-01-000825, от 20 декабря 2012 г., № ФС-67-01-000826 от 20 декабря 2012 г. и № 67.СО.02.001.Л.000006.02.01 от 19 февраля 2010 г.," +
                    " с одной стороны, и гр. \\b" + obj.PatientFIO + "\\b0 " + "  " + obj.BirthDate + " г.р.";
            if (obj.PatientSex == "мужской")
            {
                sRTF = sRTF + " именуемый ";
            }
            else
            {
                sRTF = sRTF + " именуемая ";
            }

            sRTF = sRTF + "в дальнейшем \\b«Заказчик»\\b0, с другой стороны, заключили настоящий договор о нижеследующем:";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 1.ПРЕДМЕТ ДОГОВОРА" +
                     "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 1.1. \\b0 По настоящему договору \\b«Исполнитель» \\b0 обязуется оказывать медицинские услуги \\b«Заказчику»\\b0, " +
                " а \\b«Заказчик» \\b0 обязуется принять и оплатить оказанные услуги.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 1.2. \\b«Исполнитель» \\b0 обязуется оказать медицинские услуги в форме диагностических услуг в НИИ Антимикробной химиотерапии, " +
                "расположенном по адресу г.Смоленск, ул.Кирова 46а.";
            strWr.WriteLine(sRTF);

            //if (obj.AnalysisList != null)
            //{
            //    sRTF = "\\par\\par\\qj\\fs20\\f0\\b Микробиологические анализы: \\b0";
            //    strWr.WriteLine(sRTF);
            //    strWr.WriteLine("{");
            //    strWr.WriteLine("\\par\\par\\fs20\\f0 ");

            //    foreach (var item in obj.AnalysisList)
            //    {
            //        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262\\cellx500\\cellx10500\\cellx11500";
            //        strWr.WriteLine(sRTF);
            //        sRTF = "\\pard\\intbl\\ql\\b\\ " + item.AnalysisPosition + " \\b0\\cell" +
            //"\\pard\\intbl\\qr\\b\\ " + item.AnalysisDescription + " \\b0\\cell" +
            //"\\pard\\intbl\\qr\\b\\ " + item.AnalysisPrice + " руб. 00 коп. \\b0\\cell";
            //        sRTF = "\\pard\\intbl\\row";
            //        strWr.WriteLine(sRTF);
            //    }
            //    sRTF = "}";
            //    strWr.WriteLine(sRTF);
            //}

            //if (obj.AddServiceList  != null)
            //{
            //    sRTF = "\\par\\par\\qj\\fs20\\f0\\b Дополнительные услуги: \\b0";
            //    strWr.WriteLine(sRTF);
            //    strWr.WriteLine("{");
            //    strWr.WriteLine("\\par\\par\\fs20\\f0 ");

            //    foreach (var item in obj.AddServiceList)
            //    {
            //        sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262\\cellx500\\cellx10500\\cellx11500";
            //        strWr.WriteLine(sRTF);
            //        sRTF = "\\pard\\intbl\\ql\\b\\ " + item.AddServicePosition + " \\b0\\cell" +
            //"\\pard\\intbl\\qr\\b\\ " + item.AddServiceDescription  + " \\b0\\cell" +
            //"\\pard\\intbl\\qr\\b\\ " + item.AddServicePrice  + " руб. 00 коп. \\b0\\cell";
            //        sRTF = "\\pard\\intbl\\row";
            //        strWr.WriteLine(sRTF);
            //    }
            //    sRTF = "}";
            //    strWr.WriteLine(sRTF);
            //}


            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 2.ЦЕНА УСЛУГ. ПОРЯДОК РАСЧЕТОВ ПО ДОГОВОРУ" +
             "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 2.1. \\b0 Стоимость оказываемых медицинских услуг составляет \\b" + " " + obj.TotalSum + " руб. 00 коп. \\b0 " +
               "НДС не облагается.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 2.2. \\b0 В случае оказания дополнительных медицинских услуг сумма договора может быть изменена \\b«Исполнителем» \\b0 " +
                " в одностороннем порядке в соответствии с утвержденным Прейскурантом цен на медицинские услуги.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 2.3. \\b0Стоимость оказываемых медицинских услуг определяется согласно утвержденному Прейскуранту цен на медицинские услуги.";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 3.ОБЯЗАТЕЛЬСТВА СТОРОН" +
             "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 3.1. «Исполнитель» обязуется:";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.1 \\b0 оказать услуги надлежащего качества;";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.2 \\b0 хранить в тайне информацию о факте обращения \\b«Заказчика» \\b0за медицинской помощью, состоянии его здоровья, диагнозе его заболевания и иные сведения, " +
                "полученные при  его  обследовании и лечении  (врачебная тайна),  за исключением  случаев, предусмотренных частью 4 ст. 13 ФЗ от 21.11.2011 года № 323 «Об основах охраны здоровья граждан в Российской Федерации»;";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.3 \\b0 обеспечить \\b«Заказчика» \\b0 бесплатной, доступной и достоверной информацией, включающей в себя сведения о местонахождении \\b«Исполнителя» \\b0" +
                "(месте его государственной регистрации), режиме работы, перечне платных медицинских услуг с указанием стоимости, об условиях предоставления и получения этих услуг, а также сведения о квалификации и сертификации специалистов;";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.4 \\b0оказывать \\b«Заказчику» \\b0 оказывать  «Заказчику»  услуги,  предусмотренные п. 1.2. настоящего Договора,  а  при  необходимости  и  дополнительные услуги в соответствии с требованиями " +
                " стандартов и требований к медицинским услугам на территории РФ";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.5 \\b0с согласия \\b«Заказчика» \\b0 или его представителя допускается передача сведений, составляющих врачебную тайну другим лицам, в том числе должностным лицам, в интересах диагностики и лечения \\b«Заказчика». \\b0";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.6 \\b0предоставление сведений, составляющие врачебную тайну, без согласия \\b«Заказчика» \\b0допускается с согласия его представителя в целях диагностики и лечения \\b«Заказчика» \\b0, не способного по состоянию здоровья выразить свою волю и в иных случаях, предусмотренных законодательством РФ.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.1.7 «Исполнитель» \\b0несет ответственность перед \\b«Заказчиком» \\b0за неисполнение или   ненадлежащее исполнение условий настоящего Договора, несоблюдение требований, предъявляемых " +
                "к методам диагностики разрешенным на территории Российской Федерации, а также в случае причинения вреда здоровью и жизни Заказчика в следствии, грубого нарушения установленных норм регулирующих оказание услуги. ";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.2. «Заказчик» обязуется:";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.2.1 \\b0предварительно 100% оплатить медицинские услуги,  согласно прейскуранту цен действующему на день оказания услуг, при этом по желанию предоставлять свои паспортные данные.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 3.2.2 \\b0строго соблюдать рекомендации \\b«Исполнителя» \\b0связанные с оказанием медицинских услуг по настоящему договору. " +
                "Соблюдать режимы гигиены, питания и физической активности, рекомендованные \\b«Исполнителем». \\b0";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\par\\qc\\fs20\\f0  \\b 4.РАЗРЕШЕНИЕ СПОРОВ" +
            "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 4.1 \\b0Все споры и разногласия, которые могут возникнуть между сторонами по вопросам, не нашедшим своего разрешения в тексте данного договора, будут разрешаться путем переговоров на основе действующего законодательства РФ.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 4.2 \\b0При не урегулировании в процессе переговоров спорных вопросов, споры разрешаются в судебном порядке, установленном действующим законодательством РФ.";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 5.ОТВЕТСТВЕННОСТЬ СТОРОН" +
            "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 5.1 \\b0За неисполнение или ненадлежащее исполнение обязательств по настоящему договору «Стороны» несут ответственность в соответствии с действующим законодательством РФ.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 5.2 \\b0При наличии претензий \\b«Заказчика» \\b0по качеству оказанных услуг, \\b«Исполнитель» \\b0обязан устранить данные претензии в сроки, установленные для выполнения технологического процесса и исправить допущенные ошибки за свой счет.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 5.3 \\b0Применение и исполнение санкций не освобождает «Стороны» от выполнения принятых на себя обязательств по настоящему договору.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 5.4 \\b0Ни одна из сторон не будет нести ответственность за полное или частичное неисполнение своих обязанностей, если неисполнение будет являться следствием обстоятельств непреодолимой " +
                "силы, таких как пожар, наводнение, землетрясение, забастовки и другие стихийные бедствия, война и военные действия или другие обстоятельства, находящиеся вне контроля Сторон, препятствующих выполнению настоящего Договора, а также по иным основаниям, предусмотренным законом.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 5.5 \\b0Все споры, претензии и разногласия, которые могут возникнуть между Сторонами, будут разрешаться путем переговоров.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 5.6 \\b0В  случае  невозможности   разрешения  споров  и разногласий путем  переговоров, они подлежат разрешению судом в установленном  законодательством Российской Федерации порядке.";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 6.СРОК ДЕЙСТВИЯ ДОГОВОРА" +
                "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 6.1 \\b0Настоящий договор заключен с " + obj.DateContractStart + " г. по  " + obj.DateContractEnd + " г.";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 7.ПРОЧИЕ УСЛОВИЯ" +
                "\\b0\\cf0");

            sRTF = "\\par\\par\\qj\\fs20\\f0\\b 7.1 \\b0Все дополнительные соглашения Сторон, акты и иные приложения к настоящему договору, подписываемые Сторонами при исполнении настоящего договора, являются его неотъемлемой частью.";
            strWr.WriteLine(sRTF);

            sRTF = "\\line\\b 7.2 \\b0Настоящий договор составлен в двух экземплярах, имеющих одинаковую юридическую силу, по одному для каждой из Сторон.";
            strWr.WriteLine(sRTF);

            strWr.WriteLine("\\par\\par\\qc\\fs20\\f0  \\b 8.АДРЕСА И БАНКОВСКИЕ РЕКВИЗИТЫ " +
           "\\b0\\cf0");

            strWr.WriteLine("{");
            strWr.WriteLine("\\par\\par\\fs20\\f0 ");

            sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                   "\\cellx5500\\cellx11000" +
                   "\\pard\\intbl\\ql\\b\\ " +
                    "\\bИсполнитель: \\b0\\line ГБОУ ВПО  СГМА Минздрава России, \\line 2140149, г.  Смоленск, ул. Крупской, д. 28. \\line ИНН 6731001113 КПП 673101001 УФК по Смоленской области (ГБОУ ВПО СГМА Минздрава России) \\line л/с 20636У00230 \\line Р/сч 40501810066142000001 \\line ГРКЦ ГУ Банка России по Смоленской области г. Смоленск " +
                     "\\b0\\cell" +
                   "\\pard\\intbl\\ql\\b\\ " +
                   "\\bЗаказчик \\b0\\line " +
                     " \\b0\\cell" +
                   "\\pard\\intbl\\row";
            strWr.WriteLine(sRTF);
            sRTF = "\\trowd\\trgaph30\\trleft0\\trrh262" +
                   "\\cellx5500\\cellx11000" +
                   "\\pard\\intbl\\ql\\ " +
                   "\\line\\line\\line\\line\\line ________________________/  Р.С.Козлов  / \\line МП" +
                     "\\b0\\cell" +
                   "\\pard\\intbl\\ql\\ " +
                   "\\line\\line\\line\\line\\line _______________________/  " + obj.PatientFIO + " / \\line  МП  " +
                     " \\b0\\cell" +
                   "\\pard\\intbl\\row";
            strWr.WriteLine(sRTF);
            strWr.WriteLine("}");

            // Завершаем формирование файла     
            sRTF = "}";
            strWr.WriteLine(sRTF);


            // Закрываем сесию
            strWr.Close();
            myFile.Close();
            return AppDomain.CurrentDomain.BaseDirectory + "\\\\contracts\\\\" + fileName;
            //  return AppDomain.CurrentDomain.BaseDirectory + "\\\\contracts\\\\" + fileName;
            //  return  Htmlresponse.Write("<META HTTP-EQUIV=""REFRESH"" Content=""0;URL=.\\Reports\\" & sFileName & """>")
        }
    }
}