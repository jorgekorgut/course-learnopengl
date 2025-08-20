#version 330 core
in vec2 TexCoord;
in vec3 ourColor;

out vec4 FragColor;

uniform sampler2D texture1;
uniform sampler2D texture2;

uniform float mixValue = 0.5;

void main()
{

    //vec2 updatedTextCoords = (TexCoord + vec2(0.5,0.5))*0.05;
    vec2 updatedTextCoords = TexCoord;

    FragColor = mix(texture(texture1, updatedTextCoords), texture(texture2, updatedTextCoords), mixValue);
}   