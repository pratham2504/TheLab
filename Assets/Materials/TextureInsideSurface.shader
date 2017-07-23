Shader "Texture Inside/Surface" {
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}

	SubShader
	{
		Tags { "RenderType" = "Opaque" }

		Cull Front

		CGPROGRAM

			#pragma surface surf Lambert
			sampler2D _MainTex;

			struct Input
			{
				float2 uv_MainTex;
				float4 color : COLOR;
			};

			void surf (Input IN, inout SurfaceOutput o)
			{
				fixed2 uv = IN.uv_MainTex;
				fixed3 result = tex2D(_MainTex, fixed2(1-uv.x, uv.y));
				o.Albedo = result.rgb;
				o.Alpha = 1;
			}

		ENDCG
	}

	Fallback "Diffuse"
}