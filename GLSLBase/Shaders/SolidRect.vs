#version 460

in vec3 a_Position;
in vec3 a_Velocity;
in float a_EmitTime;
in float a_A;
in float a_P;

uniform float u_Time;
uniform float u_LifeTime;

//const vec3 c_Gravity = vec3(0.f,-0.001,0.f);


void main()
{
	float time = u_Time - a_EmitTime;
	//vec3 vel = a_Velocity + c_Gravity;
	vec3 vel = a_Velocity;
	vec3 newPos = a_Position;
	
	if(time < 0.0f)
	{
		newPos = vec3(999.f,999.f,999.f);
	}
	else
	{
		//vel = vec3(0.001f,0.f,0.f);
		
		time = mod(time,u_LifeTime);
		vec3 movement = time * vel;
		vec3 head = normalize(vel);			// 이동방향
		vec3 right = cross(head,vec3(0,0,1));	// 이동방향과 카메라방향 외적 => 사인진동축
		newPos = newPos + movement;
		newPos += right * sin(time*0.005f * a_P) * a_A;		// 진동축 기준 진동
		
	}
	gl_Position = vec4(newPos, 1);
}
