// MIT License
// 
// Copyright (c) 2024 Michael Rinderle
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using Maui.Waihona.Helpers;
using Maui.Waihona.Sample.Views;

namespace Maui.Waihona.Sample;

/// <summary>
/// Represents the main application class for the Maui Waihona Sample.
/// </summary>
public partial class App
    : Application
{
    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Creates a new window for the application using the specified activation state.
    /// </summary>
    /// <param name="activationState">The activation state for the application window.</param>
    /// <returns>A new instance of the window initialized with the main page service.</returns>
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(ServiceHelper.GetService<MainPage>());
    }
}