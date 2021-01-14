using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace ChartJabel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Category> Categories { get; set; }
        private void AddText(double x, double y, string text, Color color, float angle)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(color);

            textBlock.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            if (angle <= 180)
                Canvas.SetLeft(textBlock, x);
            else
            {
                Canvas.SetLeft(textBlock, x - textBlock.DesiredSize.Width - 50);
            }
            if((angle <= 10 && angle >= 0) || (angle >= 350 && angle <= 370))
            {
                Canvas.SetTop(textBlock, y - textBlock.DesiredSize.Height - 2);
            }
            else
                Canvas.SetTop(textBlock, y);
            mainCanvas.Children.Add(textBlock);
        }
        private void AddTextMidPoint(double x, double y, string text, Color color)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(color);
            Canvas.SetLeft(textBlock, x -20 - textBlock.ActualWidth / 2);
            Canvas.SetTop(textBlock, y - textBlock.ActualHeight / 2);
            mainCanvas.Children.Add(textBlock);
        }
        public MainWindow()
        {
            InitializeComponent();

            float pieWidth = 650, pieHeight = 650, centerX = pieWidth / 2, centerY = pieHeight / 2, radius = pieWidth / 2;
            mainCanvas.Width = pieWidth;
            mainCanvas.Height = pieHeight;
            Categories = null;
            Categories = new List<Category>()
            {
                #region test #1
                new Category
                {
                    Title = "Category#01",
                    Percentage = 35,
                    ColorBrush = Brushes.Gold,
                    SLA = "1 Hour"
                },

                new Category
                {
                    Title = "Category#02",
                    Percentage = 50,
                    ColorBrush = Brushes.Pink,
                    SLA = "2 Hour"
                },

                new Category
                {
                    Title = "Category#03",
                    Percentage = 5,
                    ColorBrush = Brushes.CadetBlue,
                    SLA = "3 Hour"
                }, 
                #endregion

                #region test #2
                //new Category
                //{
                //    Title = "Category#01",
                //    Percentage = 20,
                //    ColorBrush = Brushes.Gold,
                //},

                //new Category
                //{
                //    Title = "Category#02",
                //    Percentage = 80,
                //    ColorBrush = Brushes.LightBlue,
                //}, 
                #endregion

                #region test #3
                //new Category
                //{
                //    Title = "Category#01",
                //    Percentage = 50,
                //    ColorBrush = Brushes.Gold,
                //},

                //new Category
                //{
                //    Title = "Category#02",
                //    Percentage = 50,
                //    ColorBrush = Brushes.LightBlue,
                //}, 
                #endregion

                #region test #4
                //new Category
                //{
                //    Title = "Category#01",
                //    Percentage = 30,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4472C4")),
                //},

                //new Category
                //{
                //    Title = "Category#02",
                //    Percentage = 30,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ED7D31")),
                //},

                //new Category
                //{
                //    Title = "Category#03",
                //    Percentage = 20,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC000")),
                //},

                //new Category
                //{
                //    Title = "Category#04",
                //    Percentage = 20,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B9BD5")),
                //},

                //new Category
                //{
                //    Title = "Category#05",
                //    Percentage = 10,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A5A5A5")),
                //}, 
                #endregion

                #region test #5
                //new Category
                //{
                //    Title = "Category#01",
                //    Percentage = 20,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4472C4")),
                //},

                //new Category
                //{
                //    Title = "Category#02",
                //    Percentage = 30,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ED7D31")),
                //},

                //new Category
                //{
                //    Title = "Category#03",
                //    Percentage = 20,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC000")),
                //},

                //new Category
                //{
                //    Title = "Category#04",
                //    Percentage = 20,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B9BD5")),
                //},

                //new Category
                //{
                //    Title = "Category#05",
                //    Percentage = 10,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A5A5A5")),
                //}, 
                #endregion

                //#region test #6
                //new Category
                //{
                //    Title = "Category#01",
                //    Percentage = 90,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000")),
                //},
                //new Category
                //{
                //    Title = "Category#02",
                //    Percentage = 9,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#947111")),
                //},

                //new Category
                //{
                //    Title = "Category#03",
                //    Percentage = 5,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ED7D31")),
                //},

                //new Category
                //{
                //    Title = "Category#04",
                //    Percentage = 0,
                //    ColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC000")),
                //},
                //#endregion
            };

            detailsItemsControl.ItemsSource = Categories;

            // draw pie
            float angle = 0, prevAngle = 0;
            foreach (var category in Categories)
            {
                double line1X = (radius * Math.Cos((angle-90) * Math.PI / 180)) + centerX;
                double line1Y = (radius * Math.Sin((angle-90) * Math.PI / 180)) + centerY;

                if (Categories.Count == 1)
                {
                    angle = (category.Percentage - 0.01f) * (float)360 / 100 + prevAngle;
                }
                else
                {

                    angle = category.Percentage * (float)360 / 100 + prevAngle;
                }
                Debug.WriteLine(angle);

                //midpoint pie slice
                var middlePieSliceAngle = prevAngle + (angle - prevAngle) / 2;
                double midpointSliceX = ((radius / 2) * Math.Cos((middlePieSliceAngle - 90) * Math.PI / 180)) + centerX;
                double midpointSliceY = ((radius / 2) * Math.Sin((middlePieSliceAngle - 90) * Math.PI / 180)) + centerY;

                double arcX = (radius * Math.Cos((angle - 90) * Math.PI / 180)) + centerX;
                double arcY = (radius * Math.Sin((angle - 90) * Math.PI / 180)) + centerY;

                var line1Segment = new LineSegment(new Point(line1X, line1Y), false);
                double arcWidth = radius, arcHeight = radius;
                bool isLargeArc = category.Percentage > 50;
                var arcSegment = new ArcSegment()
                {
                    Size = new Size(arcWidth, arcHeight),
                    Point = new Point(arcX, arcY),
                    SweepDirection = SweepDirection.Clockwise,
                    IsLargeArc = isLargeArc,
                };
                var line2Segment = new LineSegment(new Point(centerX, centerY), false);

                var pathFigure = new PathFigure(
                    new Point(centerX, centerY),
                    new List<PathSegment>()
                    {
                        line1Segment,
                        arcSegment,
                        line2Segment,
                    },
                    true);

                var pathFigures = new List<PathFigure>() { pathFigure, };
                var pathGeometry = new PathGeometry(pathFigures);
                var path = new Path()
                {
                    Fill = category.ColorBrush,
                    Data = pathGeometry,
                };
                mainCanvas.Children.Add(path);
                var oldAngle = prevAngle;
                prevAngle = angle;


                // draw outlines
                var outline1 = new Line()
                {
                    X1 = centerX,
                    Y1 = centerY,
                    X2 = line1Segment.Point.X,
                    Y2 = line1Segment.Point.Y,
                    Stroke = Brushes.White,
                    StrokeThickness = 5,
                };
                var outline2 = new Line()
                {
                    X1 = centerX,
                    Y1 = centerY,
                    X2 = arcSegment.Point.X,
                    Y2 = arcSegment.Point.Y,
                    Stroke = Brushes.White,
                    StrokeThickness = 5,
                };

                mainCanvas.Children.Add(outline1);
                mainCanvas.Children.Add(outline2);


                AddText(line1Segment.Point.X + 20, line1Segment.Point.Y, category.Title, (Color)ColorConverter.ConvertFromString("#000000"), oldAngle);

                AddTextMidPoint(midpointSliceX, midpointSliceY, category.SLA, (Color)ColorConverter.ConvertFromString("#000000"));

            }
        }
    }

    public class Category
    {
        public float Percentage { get; set; }
        public string Title { get; set; }
        public string SLA { get; set; }
        public Brush ColorBrush { get; set; }
    }
}