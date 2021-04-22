#version 450

layout(location=0) out vec4 FragColor;
varying vec4 v_color;

uniform float u_Time;

vec4 Radar()
{
	float d = length(v_color.rg - vec2(0,0));
	vec4 retColor = vec4(0);
	float ringRadius = mod(u_Time, 0.7);
	float radarWidth = 0.008;
	if( d > ringRadius && d < ringRadius + radarWidth)
	{
		retColor = vec4(1);
	}
	return retColor;
}

void main()
{
	FragColor = v_color;
}
