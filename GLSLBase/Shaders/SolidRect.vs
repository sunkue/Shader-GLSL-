#version 450

in vec3 a_Position;

uniform float u_Time;

varying vec4 v_Color;

void main()
{
	vec3 newPos = a_Position;
	
	gl_Position = vec4(a_Position, 1);
	v_Color = gl_Position;
}
