// ������ ������ ��� WL, ������������� owp.Cap
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WealthLab;
using WealthLab.Indicators;

namespace WealthLab.Strategies
{
	public class MyStrategy : owp.Cap
	{
		/// <summary>
		/// ���������� ���� ���, ����� ������ Execute
		/// � ��� ���������� ���� ���, ����� �������� ������
		/// </summary>
		/// <returns></returns>
		public override void Init()
		{
			// ���������, � ������ ���� �������� ������
			this.firstValidBar = 1;
		}
		/// <summary>
		/// ���������� �� ������ ���� ����� Execute
		/// � ��� ����� ���������� ��� ������� ������ ����
		/// </summary>
		/// <returns></returns>
		public override void Exec()
		{
			if (IsLastPositionActive)
			{
				//��� ������ �� �������
			}
			else
			{
				//��� ����� � �������
			}			
		}
	}
}