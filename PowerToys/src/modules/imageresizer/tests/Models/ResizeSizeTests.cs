// Copyright (c) Brice Lambson
// The Brice Lambson licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Brice Lambson's https://github.com/bricelam/ImageResizer/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using ImageResizer.Properties;
using ImageResizer.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageResizer.Models
{
    [TestClass]
    public class ResizeSizeTests
    {
        [TestMethod]
        public void NameWorks()
        {
            var size = new ResizeSize();

            var e = AssertEx.Raises<PropertyChangedEventArgs>(
                h => size.PropertyChanged += h,
                h => size.PropertyChanged -= h,
                () => size.Name = "Test");

            Assert.AreEqual("Test", size.Name);
            Assert.AreEqual(nameof(ResizeSize.Name), e.Arguments.PropertyName);
        }

        [TestMethod]
        public void NameReplacesTokens()
        {
            var args = new List<(string, string)>
            {
                ("$small$", Resources.Small),
                ("$medium$", Resources.Medium),
                ("$large$", Resources.Large),
                ("$phone$", Resources.Phone),
            };
            foreach (var (name, expected) in args)
            {
                var size = new ResizeSize
                {
                    Name = name,
                };

                Assert.AreEqual(expected, size.Name);
            }
        }

        [TestMethod]
        public void FitWorks()
        {
            var size = new ResizeSize();

            var e = AssertEx.Raises<PropertyChangedEventArgs>(
                h => size.PropertyChanged += h,
                h => size.PropertyChanged -= h,
                () => size.Fit = ResizeFit.����);

            Assert.AreEqual(ResizeFit.����, size.Fit);
            Assert.AreEqual(nameof(ResizeSize.Fit), e.Arguments.PropertyName);
        }

        [TestMethod]
        public void WidthWorks()
        {
            var size = new ResizeSize();

            var e = AssertEx.Raises<PropertyChangedEventArgs>(
                h => size.PropertyChanged += h,
                h => size.PropertyChanged -= h,
                () => size.Width = 42);

            Assert.AreEqual(42, size.Width);
            Assert.AreEqual(nameof(ResizeSize.Width), e.Arguments.PropertyName);
        }

        [TestMethod]
        public void HeightWorks()
        {
            var size = new ResizeSize();

            var e = AssertEx.Raises<PropertyChangedEventArgs>(
                h => size.PropertyChanged += h,
                h => size.PropertyChanged -= h,
                () => size.Height = 42);

            Assert.AreEqual(42, size.Height);
            Assert.AreEqual(nameof(ResizeSize.Height), e.Arguments.PropertyName);
        }

        [TestMethod]
        public void HasAutoReturnsTrueWhenWidthUnset()
        {
            var size = new ResizeSize
            {
                Width = 0,
                Height = 42,
            };

            Assert.IsTrue(size.HasAuto);
        }

        [TestMethod]
        public void HasAutoReturnsTrueWhenHeightUnset()
        {
            var size = new ResizeSize
            {
                Width = 42,
                Height = 0,
            };

            Assert.IsTrue(size.HasAuto);
        }

        [TestMethod]
        public void HasAutoReturnsFalseWhenWidthAndHeightSet()
        {
            var size = new ResizeSize
            {
                Width = 42,
                Height = 42,
            };

            Assert.IsFalse(size.HasAuto);
        }

        [TestMethod]
        public void UnitWorks()
        {
            var size = new ResizeSize();

            var e = AssertEx.Raises<PropertyChangedEventArgs>(
                h => size.PropertyChanged += h,
                h => size.PropertyChanged -= h,
                () => size.Unit = ResizeUnit.Ӣ��);

            Assert.AreEqual(ResizeUnit.Ӣ��, size.Unit);
            Assert.AreEqual(nameof(ResizeSize.Unit), e.Arguments.PropertyName);
        }

        [TestMethod]
        public void GetPixelWidthWorks()
        {
            var size = new ResizeSize
            {
                Width = 1,
                Unit = ResizeUnit.Ӣ��,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(96, result);
        }

        [TestMethod]
        public void GetPixelHeightWorks()
        {
            var size = new ResizeSize
            {
                Height = 1,
                Unit = ResizeUnit.Ӣ��,
            };

            var result = size.GetPixelHeight(100, 96);

            Assert.AreEqual(96, result);
        }

        [DataTestMethod]
        [DataRow(ResizeFit.����)]
        [DataRow(ResizeFit.���)]
        public void GetPixelHeightUsesWidthWhenScaleByPercent(ResizeFit fit)
        {
            var size = new ResizeSize
            {
                Fit = fit,
                Width = 100,
                Height = 50,
                Unit = ResizeUnit.�ٷֱ�,
            };

            var result = size.GetPixelHeight(100, 96);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenAutoAndFit()
        {
            var size = new ResizeSize
            {
                Width = 0,
                Fit = ResizeFit.����,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(double.PositiveInfinity, result);
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenAutoAndNotFit()
        {
            var size = new ResizeSize
            {
                Width = 0,
                Fit = ResizeFit.���,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenInches()
        {
            var size = new ResizeSize
            {
                Width = 0.5,
                Unit = ResizeUnit.Ӣ��,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(48, result);
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenCentimeters()
        {
            var size = new ResizeSize
            {
                Width = 1,
                Unit = ResizeUnit.����,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(38, Math.Ceiling(result));
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenPercent()
        {
            var size = new ResizeSize
            {
                Width = 50,
                Unit = ResizeUnit.�ٷֱ�,
            };

            var result = size.GetPixelWidth(200, 96);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ConvertToPixelsWorksWhenPixels()
        {
            var size = new ResizeSize
            {
                Width = 50,
                Unit = ResizeUnit.����,
            };

            var result = size.GetPixelWidth(100, 96);

            Assert.AreEqual(50, result);
        }

        [DataTestMethod]
        [DataRow(ResizeFit.���, ResizeUnit.����)]
        [DataRow(ResizeFit.���, ResizeUnit.Ӣ��)]
        [DataRow(ResizeFit.���, ResizeUnit.����)]
        [DataRow(ResizeFit.����, ResizeUnit.����)]
        [DataRow(ResizeFit.����, ResizeUnit.Ӣ��)]
        [DataRow(ResizeFit.����, ResizeUnit.����)]
        [DataRow(ResizeFit.����, ResizeUnit.����)]
        [DataRow(ResizeFit.����, ResizeUnit.Ӣ��)]
        [DataRow(ResizeFit.����, ResizeUnit.�ٷֱ�)]
        [DataRow(ResizeFit.����, ResizeUnit.����)]
        public void HeightVisible(ResizeFit fit, ResizeUnit unit)
        {
            var size = new ResizeSize
            {
                Fit = fit,
                Unit = unit,
            };

            Assert.IsTrue(size.ShowHeight);
        }

        [DataTestMethod]
        [DataRow(ResizeFit.���, ResizeUnit.�ٷֱ�)]
        [DataRow(ResizeFit.����, ResizeUnit.�ٷֱ�)]
        public void HeightNotVisible(ResizeFit fit, ResizeUnit unit)
        {
            var size = new ResizeSize
            {
                Fit = fit,
                Unit = unit,
            };

            Assert.IsFalse(size.ShowHeight);
        }
    }
}
