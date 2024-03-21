using BookLibrary;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookLibraryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public Library LibraryKNM { get; set; } = Library.Instance;
        public MainWindow()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            IDsList.Items.Clear();
            BookList.Items.Clear();
            AuthorList.Items.Clear();
            ReleaseList.Items.Clear();
            GenreList.Items.Clear();
            foreach (var book in LibraryKNM.Books.ToList())
            {
                IDsList.Items.Add(book.ID); 
                BookList.Items.Add(book.ToString()); 
                AuthorList.Items.Add(book.Author); 
                ReleaseList.Items.Add(book.ReleaseDate);
                GenreList.Items.Add(book.Genre);
            }
        }
        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuItem_AddBook_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the window you want to open
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.MainWindowReference = this;
            // Show the window
            addBookWindow.Show();
        }
        public void MenuItem_AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.MainWindowReference = this;
            addUserWindow.Show();
        }
        private void MenuItem_ViewUser_Click(object sender, RoutedEventArgs e)
        {
            ViewUserWindow viewUserWindow = new ViewUserWindow();
            viewUserWindow.MainWindowReference = this;
            viewUserWindow.Show();
        }
        public void ToExcel_Click(object sender, RoutedEventArgs e)
        {
            ListView[] listViews = new ListView[] { IDsList, BookList, AuthorList, ReleaseList, GenreList};
            string pathWithEnv = @"%USERPROFILE%\Desktop\test.xlsx";
            string filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            ExportListViewsToExcel(listViews, filePath);
        }
        private void Borrow_Click (object sender, RoutedEventArgs e)
        {
            BorrowWindow borrowWindow = new BorrowWindow();
            borrowWindow.MainWindowReference = this;
            borrowWindow.ShowDialog();
            Refresh();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void ExportListViewsToExcel(ListView[] listViews, string filePath)
        {
            // Initialize Excel application
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            // Create a new workbook and add a worksheet
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Worksheets[1];

            int rowIndex = 1;
            int columnIndex = 1;

            // Iterate through each ListView
            foreach (ListView listView in listViews)
            {
                // Write the column header to the first row of the Excel sheet
                worksheet.Cells[1, columnIndex] = listView.Name;

                // Iterate through each item in the ListView
                foreach (dynamic listViewItem in listView.Items)
                {
                    // Write the item's content to the Excel worksheet
                    worksheet.Cells[rowIndex + 1, columnIndex] = listViewItem.ToString();
                    rowIndex++;
                }

                // Move to the next column for the next ListView
                columnIndex++;
                rowIndex = 1; // Reset rowIndex for the next ListView
            }

            // AutoSet Cell Widths to Content Size
            worksheet.Cells.Select();
            worksheet.Cells.EntireColumn.AutoFit();

            // Save the workbook to a file
            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            // Release COM objects
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
