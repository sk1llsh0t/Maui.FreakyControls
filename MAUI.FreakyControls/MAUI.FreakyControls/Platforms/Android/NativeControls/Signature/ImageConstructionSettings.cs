﻿using NativeColor = Android.Graphics.Color;
using NativeNullableColor = System.Nullable<Android.Graphics.Color>;

namespace Maui.FreakyControls.Platforms.Android;

public struct ImageConstructionSettings
{
    public static readonly bool DefaultShouldCrop = true;
    public static readonly SizeOrScale DefaultSizeOrScale = 1f;
    public static readonly NativeColor DefaultStrokeColor = NativeColor.Black;
    public static readonly NativeColor DefaultBackgroundColor = NativeColor.White;
    public static readonly float DefaultStrokeWidth = 2f;
    public static readonly float DefaultPadding = 5f;

    public bool? ShouldCrop { get; set; }

    public SizeOrScale? DesiredSizeOrScale { get; set; }

    public NativeNullableColor StrokeColor { get; set; }

    public NativeNullableColor BackgroundColor { get; set; }

    public float? StrokeWidth { get; set; }

    public float? Padding { get; set; }

    internal void ApplyDefaults()
    {
        ApplyDefaults(DefaultStrokeWidth, DefaultStrokeColor);
    }

    internal void ApplyDefaults(float strokeWidth, NativeColor strokeColor)
    {
        ShouldCrop ??= DefaultShouldCrop;
        DesiredSizeOrScale ??= DefaultSizeOrScale;
        StrokeColor ??= strokeColor;
        BackgroundColor ??= DefaultBackgroundColor;
        StrokeWidth ??= strokeWidth;
        Padding ??= DefaultPadding;
    }
}