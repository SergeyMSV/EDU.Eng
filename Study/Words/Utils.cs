using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Words
{
    class Utils
    {
        public static void DataGrigView_FindFirstSymbolInCell(DataGridView dataGrid, ref int findCharIndex, ref int findLastPosition, ref char lastSymbol, char newSymbol)
        {
            if (newSymbol != lastSymbol ||
                findLastPosition != dataGrid.SelectedCells[0].RowIndex)
            {
                findCharIndex = dataGrid.SelectedCells[0].RowIndex;
                lastSymbol = newSymbol;
            }

            for (int i = 0; i < dataGrid.Rows.Count; i++, findCharIndex++)
            {
                if (findCharIndex == dataGrid.Rows.Count)
                    findCharIndex = 0;
                try
                {
                    if (lastSymbol.ToString().ToLower()[0] == dataGrid.Rows[findCharIndex].Cells[dataGrid.SelectedCells[0].ColumnIndex].Value.ToString().ToLower()[0])
                    {
                        dataGrid.Rows[findCharIndex].Cells[dataGrid.SelectedCells[0].ColumnIndex].Selected = true;
                        findLastPosition = findCharIndex;
                        findCharIndex++;
                        break;
                    }
                }
                catch { }
            }
        }

        public static void DataGrigView_FindStringInCells(DataGridView dataGrid, int quantityOfColumns, ref Point findIndex, ref Point findLastPosition, ref string lastString, string newString)
        {
            if (newString != lastString ||
                findLastPosition.Y != dataGrid.SelectedCells[0].RowIndex ||
                findLastPosition.X != dataGrid.SelectedCells[0].ColumnIndex)
            {
                findIndex.Y = dataGrid.SelectedCells[0].RowIndex;
                findIndex.X = dataGrid.SelectedCells[0].ColumnIndex;
                lastString = newString;
            }

            for (int i = 0; i < dataGrid.Columns.Count * dataGrid.Rows.Count; i++, findIndex.X++)
            {
                if (findIndex.X == quantityOfColumns)//dataGrid.Columns.Count)
                {
                    findIndex.X = 0;
                    findIndex.Y++;
                    if (findIndex.Y == dataGrid.Rows.Count)
                        findIndex.Y = 0;
                }

                try
                {
                    if (dataGrid.Rows[findIndex.Y].Cells[findIndex.X].Value.ToString().ToLower().Contains(lastString.ToLower()))
                    {
                        dataGrid.Rows[findIndex.Y].Cells[findIndex.X].Selected = true;
                        findLastPosition = findIndex;
                        findIndex.X++;
                        return;
                    }
                }
                catch { }
            }
        }
    }
}