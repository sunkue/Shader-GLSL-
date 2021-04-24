#version 450

layout(location=0) out vec4 FragColor;

varying vec4 v_Color;

const float PI = 3.141592;
const uint numOfPoints = 10;
uniform vec3 u_Point;
uniform vec3 u_Points[numOfPoints];
uniform float u_Time;


vec4 Radar()
{
	float time = -u_Time * 10.0f;
	float d = length(v_Color.rg - vec2(0,0));
	vec4 retColor = vec4(0);
	float ringRadius = mod(time, 0.7);
	float radarWidth = 0.008;
	if( d > ringRadius && d < ringRadius + radarWidth)
	{
		retColor = vec4(1);
	}
	return retColor;
}

vec4 Wave()
{
	vec4 retColor = vec4(0);
	uint n = 2;//numOfPoints;
	for(int i = 0 ; i < n ; ++i){
		vec2 ori = u_Points[i].xy;
		vec2 pos = v_Color.rg;
		float d = length(ori - pos);
		float preq = 28.0;
		float time = -u_Time * 0.015f;
		retColor += vec4( sin(d * 2 * PI * preq + time) );
	}
	//retColor = normalize(retColor);
	return retColor;
}

void main()
{
	FragColor = Wave();
}
