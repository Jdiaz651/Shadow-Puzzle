Shader "Custom/ShadowOnly"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Lighting On
        Pass
        {
            ColorMask 0 // Don't render any color
        }
    }
}
