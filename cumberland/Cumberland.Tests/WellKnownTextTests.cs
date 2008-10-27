// WellKnownTextTests.cs
//
// Copyright (c) 2008 Scott Ellington and Authors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using System.Collections.Generic;
using Cumberland;

using NUnit.Framework;

namespace Cumberland.Tests
{
	[TestFixture]
	public class WellKnownTextTests
	{
		[Test]
		public void TestWKTPoint()
		{
			string wkt = "POINT(0 0)";
			
			Point p = WellKnownText.ParsePoint(wkt);
			
			Assert.AreEqual(new Point(0,0), p);
		}
		
		[Test]
		public void TestWKTMultLineString()
		{
			string wkt = "MULTILINESTRING((0 0 0,1 1 0,1 2 1),(2 3 1,3 2 1,5 4 1))";
			
			WellKnownText.ParseMultiLineString(wkt);
		}
		
		[Test]
		public void TestWKTMultiPolygon()
		{
			string wkt = "MULTIPOLYGON(((0 0 0,4 0 0,4 4 0,0 4 0,0 0 0),(1 1 0,2 1 0,2 2 0,1 2 0,1 1 0)),((-1 -1 0,-1 -2 0,-2 -2 0,-2 -1 0,-1 -1 0)))";
			
			List<Feature> l = WellKnownText.ParseMultiPolygon(wkt);
			
			Assert.IsTrue(l.Count == 2);
		}
	}
}