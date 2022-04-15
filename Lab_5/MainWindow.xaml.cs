using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Controls;

namespace WpfTutorialSamples.Rich_text_controls
{
	public partial class RichTextEditorSample : Window
	{
		public RichTextEditorSample()
		{
			InitializeComponent();
			cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };			
			colorFont.ItemsSource = new List<string> {"красный", "оранжевый", "жетлый", "зеленый", "голубой", "синий", "фиолетовый" };
		}
		
		private void colorFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (colorFont.SelectedItem.Equals("красный"))
			{
				rtbEditor.Foreground = Brushes.Red;
			}
			if (colorFont.SelectedItem.Equals("оранжевый"))
			{
				rtbEditor.Foreground = Brushes.Orange;
			}
			if (colorFont.SelectedItem.Equals("жетлый"))
			{
				rtbEditor.Foreground = Brushes.Yellow;
			}
			if (colorFont.SelectedItem.Equals("зеленый"))
			{
				rtbEditor.Foreground = Brushes.Green;
			}
			if (colorFont.SelectedItem.Equals("голубой"))
			{
				rtbEditor.Foreground = Brushes.Blue;
			}
			if (colorFont.SelectedItem.Equals("синий"))
			{
				rtbEditor.Foreground = Brushes.MediumBlue;
			}
			if (colorFont.SelectedItem.Equals("фиолетовый"))
			{
				rtbEditor.Foreground = Brushes.Purple;
			}
		}

		private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{

			object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
			btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
			btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
			temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			cmbFontFamily.SelectedItem = temp;
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
			cmbFontSize.Text = temp.ToString();
		}

		private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Rtf);
			}
		}

		private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Save(fileStream, DataFormats.Rtf);
			}
		}

		private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontFamily.SelectedItem != null)
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
		}

		private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
		{
			rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
		}

        private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rtbEditor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
	}

}