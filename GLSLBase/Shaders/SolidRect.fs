#version 450

uniform sampler2D u_TexSampler;
in vec2 v_TexPos;

out vec4 FragColor;

vec2 f3(vec2 tex)
{
	tex.y = fract((1.0f - ceil(tex.x * 3.0f)/3.0f) + tex.y/3.04f);
	tex.x = fract(tex.x * 3.0f);
	return tex;
}

vec2 f4(vec2 tex)
{
	tex.y = fract(tex.y + (ceil(tex.y * 3.0f) - 2.01f)/3.0f);
	return tex;
}

vec2 f5(vec2 tex)
{
	tex.x = fract(tex.x * 2.0f + round(tex.y) * 0.5f);
	tex.y = fract(tex.y * 2.0f);
	return tex;
}

vec2 f6(vec2 tex)
{
	tex.y = fract(tex.y * 2.0f + round(tex.x) * 0.5f);
	tex.x = fract(tex.x * 2.0f);
	return tex;
}

void main()
{
	vec2 tex = fX(v_TexPos);
	FragColor = texture(u_TexSampler, tex) + vec4(0.1f);
}
