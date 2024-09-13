//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace PixelSmith.Effects {
	
	public class MirrorHorizontalEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(MirrorHorizontalEffect), 0);
		public static readonly DependencyProperty ReflectionHeightProperty = DependencyProperty.Register("ReflectionHeight", typeof(double), typeof(MirrorHorizontalEffect), new UIPropertyMetadata(((double)(1D)), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty MirrorLocationProperty = DependencyProperty.Register("MirrorLocation", typeof(double), typeof(MirrorHorizontalEffect), new UIPropertyMetadata(((double)(0.5D)), PixelShaderConstantCallback(1)));
		public MirrorHorizontalEffect() {
			PixelShader pixelShader = new PixelShader();
			pixelShader.UriSource = new Uri("/PixelSmith;component/Effects/MirrorHorizontalEffect.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(ReflectionHeightProperty);
			this.UpdateShaderValue(MirrorLocationProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		public double ReflectionHeight {
			get {
				return ((double)(this.GetValue(ReflectionHeightProperty)));
			}
			set {
				this.SetValue(ReflectionHeightProperty, value);
			}
		}
		public double MirrorLocation {
			get {
				return ((double)(this.GetValue(MirrorLocationProperty)));
			}
			set {
				this.SetValue(MirrorLocationProperty, value);
			}
		}
	}
}