using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMC.Model.Models;
using UMC.Service;
using UMC.WApp.Models;
using UMC.WApp.Infrastructure.Extensions;
using System.Runtime.InteropServices;
using UMC.Data.Repositories;

namespace UMC.WApp
{
    public partial class frmShift : Form
    {
        private IShiftService _shiftService;

        public frmShift()
        {
            InitializeComponent();
        }

        public frmShift(IShiftService shiftService) : this()
        {
            InitializeComponent();
            _shiftService = shiftService;    
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                ShiftViewModel shiftViewModel = new ShiftViewModel();
                shiftViewModel.Name = txtName.Text;
                shiftViewModel.From = DateTime.Now;
                shiftViewModel.To = DateTime.Now;

                Shift newShift = new Shift();
                newShift.UpdateShift(shiftViewModel);

                await _shiftService.Add(newShift);
                await _shiftService.SaveAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "\nLỗi\n" +
                    ex.Message);
            }
        }
    }
}
