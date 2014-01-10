using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDataLib.BO;
using CSharpJExcel.Jxl;
using CSharpJExcel.Jxl.Format;

namespace GDataLib.SOL
{
    public class Processor
    {
        private String ExcelPath;

        private Sheet Sheet;

        private String[] Stations = { "UTOROGU", "UGHELLI  EAST", "UGHELLI WEST", "ABURA" };

        private int GasPlantStartRow;

        private int FlowStationStartRow;

        private int GasLiftStartRow;

        public Processor(String ExcelPath)
        {
            this.ExcelPath = ExcelPath;
            if (LoadFile())
            {
                if (this.Sheet != null)
                {

                    this.GasPlantStartRow = this.GetGasPlantStartRow();
                    this.FlowStationStartRow = this.GetFlowStationStartRow();
                    this.GasLiftStartRow = this.GetGasLiftStartRow();
                }
                else
                {
                    //sheet null
                }

            }
            else
            {
                //file load fail
            }

        }

        private int GetFlowStationStartRow()
        {
            try
            {
                int _Row = -1;
                String Marker = "FLOW STATIONS";
                for (int i = 1; i < this.Sheet.getRows(); i++)
                {
                    var _Cell = this.Sheet.getCell("B" + i).getContents();


                    if (_Cell.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper())
                    {
                        _Row = i;
                    }

                }

                return _Row;
            }
            catch (Exception Ew)
            {
                return -1;
            }
        }

        private int GetGasPlantStartRow()
        {
            try
            {
                int _Row = -1;
                String Marker = "GAS PLANT";
                for (int i = 1; i < this.Sheet.getRows(); i++)
                {
                    var _Cell = this.Sheet.getCell("B" + i).getContents();


                    if (_Cell.Trim().RemoveWhitespace().ToUpper() == Marker.RemoveWhitespace().ToUpper())
                    {
                        _Row = i;
                    }

                }

                return _Row;
            }
            catch (Exception Ew)
            {
                return -1;
            }

        }

        private int GetGasLiftStartRow()
        {
            try
            {
                int _Row = -1;
                String Marker = "GAS LIFT";
                for (int i = 1; i < this.Sheet.getRows(); i++)
                {
                    var _Cell = this.Sheet.getCell("B" + i).getContents();


                    if (_Cell.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper())
                    {
                        _Row = i;
                    }

                }

                return _Row;
            }
            catch (Exception Ew)
            {
                return -1;
            }
        }

        private bool LoadFile()
        {

            try
            {
                Workbook workbook = Workbook.getWorkbook(new System.IO.FileInfo(this.ExcelPath));
                this.Sheet = workbook.getSheet(0);
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
        }

        public List<Readings> Process()
        {
            List<Readings> _Readings = new List<Readings>();
            try
            {
                foreach (String _Station in this.Stations)
                {
                    var _Reading = new Readings();
                    _Reading.ReadingsId = Guid.NewGuid();
                    _Reading.Field = _Station;
                    _Reading.Date = this.GetDate();
                    _Reading.OilProduced = this.GetOilProduced(_Station);
                    _Reading.GasLift = this.GetGasLiftProduced(_Station);
                    _Reading.NAGProduced = this.GetNAGProduced(_Station);
                    _Reading.CONGProduced = this.GetCONGProduced(_Station);
                    _Reading.BSWProduced = this.GetBSWProduced(_Station);
                    _Readings.Add(_Reading);

                }

                return _Readings;
            }
            catch (Exception Ew)
            {
                return null;
            }
        }

        private double GetBSWProduced(string _Station)
        {
            try
            {
                int _Index = this.FlowStationStartRow;

                double _Data = 0.0;
                String Marker = _Station;

                while (true)
                {
                    var _Cell = this.Sheet.getCell("B" + _Index);

                    var _Content = _Cell.getContents();

                    var _Format = _Cell.getCellFormat();

                    if (_Format.getBackgroundColour() == Colour.YELLOW)
                    {
                        //end of the block
                        break;
                    }
                    else
                    {

                        if (_Content.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper() || _Content.Trim().RemoveWhitespace().ToUpper().Contains(Marker.Trim().RemoveWhitespace().ToUpper()))
                        {
                            //Station Found
                            var _CellData = this.Sheet.getCell("E" + _Index).getContents();

                            _Data = Convert.ToDouble(_CellData);
                            break;
                        }
                        else
                        {
                            _Index++;
                            continue;
                        }

                    }


                }

                return _Data;
            }
            catch (Exception Ew)
            {
                return 0.0;
            }
        }

        private double GetCONGProduced(string _Station)
        {
            try
            {
                int _Index = this.GasPlantStartRow;

                double _Data = 0.0;
                String Marker = _Station;

                while (true)
                {
                    var _Cell = this.Sheet.getCell("B" + _Index);

                    var _Content = _Cell.getContents();

                    var _Format = _Cell.getCellFormat();

                    if (_Format.getBackgroundColour() == Colour.YELLOW)
                    {
                        //end of the block
                        break;
                    }
                    else
                    {

                        if (_Content.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper() || _Content.Trim().RemoveWhitespace().ToUpper().Contains(Marker.Trim().RemoveWhitespace().ToUpper()))
                        {
                            //Station Found
                            var _CellData = this.Sheet.getCell("E" + _Index).getContents();

                            _Data = Convert.ToDouble(_CellData);
                            break;
                        }
                        else
                        {
                            _Index++;
                            continue;
                        }

                    }


                }

                return _Data;
            }
            catch (Exception Ew)
            {
                return 0.0;
            }
        }

        private double GetNAGProduced(string _Station)
        {
            try
            {
                int _Index = this.GasPlantStartRow;

                double _Data = 0.0;
                String Marker = _Station;

                while (true)
                {
                    var _Cell = this.Sheet.getCell("B" + _Index);

                    var _Content = _Cell.getContents();

                    var _Format = _Cell.getCellFormat();

                    if (_Format.getBackgroundColour() == Colour.YELLOW)
                    {
                        //end of the block
                        break;
                    }
                    else
                    {

                        if (_Content.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper() || _Content.Trim().RemoveWhitespace().ToUpper().Contains(Marker.Trim().RemoveWhitespace().ToUpper()))
                        {
                            //Station Found
                            var _CellData = this.Sheet.getCell("D" + _Index).getContents();

                            _Data = Convert.ToDouble(_CellData);
                            break;
                        }
                        else
                        {
                            _Index++;
                            continue;
                        }

                    }


                }

                return _Data;
            }
            catch (Exception Ew)
            {
                return 0.0;
            }
        }

        private double GetGasLiftProduced(string _Station)
        {
            try
            {
                int _Index = this.GasLiftStartRow;

                double _Data = 0.0;
                String Marker = _Station;

                while (true)
                {
                    var _Cell = this.Sheet.getCell("B" + _Index);

                    var _Content = _Cell.getContents();

                    var _Format = _Cell.getCellFormat();

                    if (_Format.getBackgroundColour() == Colour.YELLOW)
                    {
                        //end of the block
                        break;
                    }
                    else
                    {

                        if (_Content.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper() || _Content.Trim().RemoveWhitespace().ToUpper().Contains(Marker.Trim().RemoveWhitespace().ToUpper()))
                        {
                            //Station Found
                            var _CellData = this.Sheet.getCell("D" + _Index).getContents();

                            _Data = Convert.ToDouble(_CellData);
                            break;
                        }
                        else
                        {
                            _Index++;
                            continue;
                        }

                    }


                }

                return _Data;
            }
            catch (Exception Ew)
            {
                return 0.0;
            }
        }

        private DateTime GetDate()
        {
            try
            {
                var _CellData = this.Sheet.getCell("H3").getContents().Trim();

                return Convert.ToDateTime(_CellData);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        private double GetOilProduced(string _Station)
        {
            try
            {
                int _Index = this.FlowStationStartRow;

                double _Data = 0.0;
                String Marker = _Station;

                while (true)
                {
                    var _Cell = this.Sheet.getCell("B" + _Index);

                    var _Content = _Cell.getContents();

                    var _Format = _Cell.getCellFormat();

                    if (_Format.getBackgroundColour() == Colour.YELLOW)
                    {
                        //end of the block
                        break;
                    }
                    else
                    {

                        if (_Content.Trim().RemoveWhitespace().ToUpper() == Marker.Trim().RemoveWhitespace().ToUpper() || _Content.Trim().RemoveWhitespace().ToUpper().Contains(Marker.Trim().RemoveWhitespace().ToUpper()))
                        {
                            //Station Found
                            var _CellData = this.Sheet.getCell("D" + _Index).getContents();

                            _Data = Convert.ToDouble(_CellData);
                            break;
                        }
                        else
                        {
                            _Index++;
                            continue;
                        }

                    }


                }

                return _Data;
            }
            catch (Exception Ew)
            {
                return 0.0;
            }
        }



    }
}
