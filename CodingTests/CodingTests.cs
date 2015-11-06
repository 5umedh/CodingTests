using CSharpTest.Solution;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CodingTests
{
	public partial class CodingTests : Form
	{
		public CodingTests()
		{
			InitializeComponent();
		}



		private Solution _testSol;


		/// <summary>
		/// Form Load : Initilizes the Solution class from 'CSharpTest.Solution' namespace
		/// </summary>
		/// <param name="sender">Sender is RuntimeType in this case</param>
		/// <param name="e">event arguments in this case empty</param>
		private void CodingTests_Load(object sender, EventArgs e)
		{
			_testSol = new Solution();
		}



		/// <summary>
		/// Occurrence Button click: calls the "GetIntegerDecimalOccurrence" method.
		/// </summary>
		/// <param name="sender">Sender is button in this case</param>
		/// <param name="e">event arguments in case of mouse click</param>
		private void btnOccurrence_Click(object sender, EventArgs e)
		{
			try
			{
				var numberToSearch = int.Parse(txtFind.Text);
				var sourceNumber = int.Parse(txtSource.Text);

				var result = _testSol.GetIntegerDecimalOccurrence(numberToSearch, sourceNumber);

				//ternary to check if the number is found in source : show output message accordingly
				var output = result == -1 ? "The number to be searched for does not occur in provided source number."
					: $"The number to be searched for occurs at index position '{result.ToString(CultureInfo.InvariantCulture)}' in provided source number.";

				MessageBox.Show(output);
			}
			catch (FormatException formatEx)
			{
				MessageBox.Show("Please provide a valid integer value: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //TODO: the error string should come from resources file
			}
			catch (OverflowException)
			{
				MessageBox.Show(
				    $"Please provide a valid integer value between {Constants.LowerLimitForSearchInteger} to {Constants.UpperLimitForSearchInteger}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //TODO: the error string should come from resources file
			}
			catch (ArgumentOutOfRangeException argEx)
			{
				MessageBox.Show(argEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// OccurrencePrimitives Button click: calls the "GetIntegerDecimalOccurrencePrimitive" method.
		/// </summary>
		/// <param name="sender">Sender is button in this case</param>
		/// <param name="e">event arguments in case of mouse click</param>
		private void btnOccurrencePrimitives_Click(object sender, EventArgs e)
		{
			try
			{
				var numberToSearch = int.Parse(txtFind.Text);
				var sourceNumber = int.Parse(txtSource.Text);

				var result = _testSol.GetIntegerDecimalOccurrencePrimitive(numberToSearch, sourceNumber);

				//ternary to check if the number is found in source : show output message accordingly
				var output = result == -1 ? "The number to be searched for does not occur in provided source number."
					: $"The number to be searched for occurs at index position '{result.ToString(CultureInfo.InvariantCulture)}' in provided source number.";

				MessageBox.Show(output, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (FormatException formatEx)
			{
				MessageBox.Show($"Please provide a valid integer value: {formatEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //TODO: the error string should come from resources file
			}
			catch (OverflowException)
			{
				MessageBox.Show(
				    $"Please provide a valid integer value between {Constants.LowerLimitForSearchInteger} to {Constants.UpperLimitForSearchInteger}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //TODO: the error string should come from resources file
			}
			catch (ArgumentOutOfRangeException argEx)
			{
				MessageBox.Show(argEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// ReverseString Button click: calls the "ReverseString" method.
		/// </summary>
		/// <param name="sender">Sender is button in this case</param>
		/// <param name="e">event arguments in case of mouse click</param>
		private void btnReverseString_Click(object sender, EventArgs e)
		{
			try
			{
				var reverseString = _testSol.ReverseString(txtInputString.Text);
				MessageBox.Show(reverseString, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// ReverseStringPrimitive Button click: calls the "ReverseStringPrimitive" method.
		/// </summary>
		/// <param name="sender">Sender is button in this case</param>
		/// <param name="e">event arguments in case of mouse click</param>
		private void btnReverseStringPrimitive_Click(object sender, EventArgs e)
		{
			try
			{
				var reverseString = _testSol.ReverseStringPrimitive(txtInputString.Text);
				MessageBox.Show(reverseString, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	}
}
