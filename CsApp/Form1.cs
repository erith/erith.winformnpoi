using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using NPOI.XSSF.Model; // InternalWorkbook
using NPOI.XSSF.UserModel; // HSSFWorkbook, HSSFSheet

namespace CsApp
{
    public partial class Form1 : Form
    {
        XmlDocument menu = new XmlDocument();
        XSSFWorkbook wb;
 

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼로드시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //메뉴 XML 파일 로드
            var path = Application.StartupPath + @"\menu.xml";            
            menu.Load(path);
            var nodes = menu.SelectNodes("/menulist/menu");
            foreach(XmlNode node in nodes)
            {
                ct01.Items.Add(node.Attributes["title"].Value);
            }

        }


        /// <summary>
        /// 콤보박스 1 선택시 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ct01_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = ct01.SelectedIndex;
            var nodes = menu.SelectNodes("/menulist/menu[" + idx + "]/menulist/menu");
            ct02.Items.Clear();
            foreach (XmlNode node in nodes)
            {
                ct02.Items.Add(node.Attributes["title"].Value);
            }
        }

        //저장 버튼 클릭
        private void btn_click_Click(object sender, EventArgs e)
        {
            //파일 경로 읽어오기
            var savepath = Application.StartupPath + @"\DATA.xlsx";


            //워크북에 엑셀파일 로드하기
            using (var file = new FileStream(savepath, FileMode.Open, FileAccess.ReadWrite))
            {
                wb = new XSSFWorkbook(file);
            }
            var sheet = wb.GetSheetAt(0);

            //마지막에 입력된 로우번호를 가지고 온다.
            int row_count = sheet.PhysicalNumberOfRows;

            //윈도우 폼에 입력된 글자 가져오기
            XSSFRichTextString str = new XSSFRichTextString(tb01.Text);

            //시트에 로우 만들기.
            var row = sheet.CreateRow(row_count);
            var cell = row.CreateCell(0);
            cell.SetCellType(NPOI.SS.UserModel.CellType.String);
            var cs =wb.CreateCellStyle();
            cs.WrapText = true;
            cell.CellStyle = cs;
            cell.SetCellValue(str);
            
            //워크시트 파일로 저장하기
            using (var file2 = new FileStream(savepath, FileMode.Create, FileAccess.ReadWrite))
            {
                wb.Write(file2);
                file2.Close();
            }	
        }
    }
}
