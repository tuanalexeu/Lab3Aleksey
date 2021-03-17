using System;

namespace Lab3Aleksey {
    public class GausMethod {
      public uint RowCount;
      public uint ColumCount;
      public double[][] Matrix { get; set; }
      public double[] RightPart { get; set; }
      public double[] Answer { get; set; }
   
      public GausMethod(uint Row, uint Colum)
      {
        RightPart = new double[Row];
        Answer = new double[Row];
        Matrix = new double[Row][];
        for (int i = 0; i < Row; i++)
          Matrix[i] = new double[Colum];
        RowCount = Row;
        ColumCount = Colum;
   
        //обнулим массив
        for (int i = 0; i < Row; i++)
        {
          Answer[i] = 0;
          RightPart[i] = 0;
          for (int j = 0; j < Colum; j++)
            Matrix[i][j] = 0;
        }
      }
   
      private void SortRows(int SortIndex)
      {
   
        double MaxElement = Matrix[SortIndex][SortIndex];
        int MaxElementIndex = SortIndex;
        for (int i = SortIndex + 1; i < RowCount; i++)
        {
          if (Matrix[i][SortIndex] > MaxElement)
          {
            MaxElement = Matrix[i][SortIndex];
            MaxElementIndex = i;
          }
        }
   
        //теперь найден максимальный элемент ставим его на верхнее место
        if (MaxElementIndex > SortIndex)//если это не первый элемент
        {
          double Temp;
   
          Temp = RightPart[MaxElementIndex];
          RightPart[MaxElementIndex] = RightPart[SortIndex];
          RightPart[SortIndex] = Temp;
   
          for (int i = 0; i < ColumCount; i++)
          {
            Temp = Matrix[MaxElementIndex][i];
            Matrix[MaxElementIndex][i] = Matrix[SortIndex][i];
            Matrix[SortIndex][i] = Temp;
          }
        }
      }

      public double[] SolveMatrix()
      {
        if (RowCount != ColumCount)
          return null; //нет решения
   
        for (int i = 0; i < RowCount - 1; i++)
        {
          SortRows(i);
          for (int j = i + 1; j < RowCount; j++)
          {
            if (Matrix[i][i] != 0) //если главный элемент не 0, то производим вычисления
            {
              double MultElement = Matrix[j][i] / Matrix[i][i];
              for (int k = i; k < ColumCount; k++)
                Matrix[j][k] -= Matrix[i][k] * MultElement;
              RightPart[j] -= RightPart[i] * MultElement;
            }
            //для нулевого главного элемента просто пропускаем данный шаг
          }
        }
   
        //ищем решение
        for (int i = (int)(RowCount - 1); i >= 0; i--)
        {
          Answer[i] = RightPart[i];
   
          for (int j = (int)(RowCount - 1); j > i; j--)
            Answer[i] -= Matrix[i][j] * Answer[j];
   
          if (Matrix[i][i] == 0)
            if (RightPart[i] == 0)
              return null; //множество решений
            else
              return null; //нет решения
   
          Answer[i] /= Matrix[i][i];
   
        }
        return Answer;
      }
    }
}