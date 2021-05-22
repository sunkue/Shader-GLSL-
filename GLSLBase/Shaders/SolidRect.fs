#version 450

uniform sampler2D u_TexSampler;
in vec2 v_TexPos;

out vec4 FragColor;

float f(vec2 tex)
{
	float y = (abs(0.5f - tex.y) * 2);
	y = y - 1.0f;
	y = fract( y * 2.0f);
	return y;
}

void main()
{
	vec2 tex = vec2( v_TexPos.x, f(v_TexPos) );
	FragColor = texture(u_TexSampler, tex) + vec4(0.1f);
}
