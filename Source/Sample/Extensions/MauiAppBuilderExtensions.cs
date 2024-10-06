// MIT License
// 
// Copyright (c) 2024 Michael Rinderle
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
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

using Maui.Waihona.Sample.ViewModels;
using Maui.Waihona.Sample.Views;

namespace Maui.Waihona.Sample.Extensions;

/// <summary>
/// Provides extension methods for the MauiAppBuilder class to
/// add and configure various components such as ViewModels and Views.
/// </summary>
public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// Adds ViewModels to the Maui application builder.
    /// </summary>
    /// <param name="builder">The Maui application builder to which the ViewModels will be added.</param>
    /// <returns>The Maui application builder with the added ViewModels.</returns>
    public static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {
        builder.Services
            .AddSingleton<AppShellViewModel>()
            .AddSingleton<MainPageViewModel>();
        
        return builder;
    }

    /// <summary>
    /// Adds Views to the Maui application builder.
    /// </summary>
    /// <param name="builder">The Maui application builder to which the Views will be added.</param>
    /// <returns>The Maui application builder with the added Views.</returns>
    public static MauiAppBuilder AddViews(this MauiAppBuilder builder)
    {
        builder.Services
            .AddSingleton<AppShell>()
            .AddSingleton<MainPage>();
        
        
        return builder;
    }
}