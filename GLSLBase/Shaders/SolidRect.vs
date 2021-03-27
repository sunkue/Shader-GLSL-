#version 460

in vec3 a_Position;
in vec3 a_Velocity;

uniform float u_time;

const vec3 c_Gravity = vec3(0,-0.001,0);

void main()
{
	vec3 vel = a_Velocity + c_Gravity;
	vec3 movement = u_time * vel;
	vec3 newPos = a_Position + movement;
	
	gl_Position = vec4(sin(newPos), 1);
}
