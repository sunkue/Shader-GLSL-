#version 450

uniform sampler2D u_TexSampler;
in vec2 v_TexPos;

out vec4 FragColor;

vec2 f(vec2 tex)
{
	tex *= 2.0f;
	if(1.0f < tex.x)tex.y -= 0.5f;
	return tex;
}

void main()
{
	vec2 tex = f(v_TexPos);
	FragColor = texture(u_TexSampler, tex) + vec4(0.1f);
}
