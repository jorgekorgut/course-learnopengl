#version 330 core
in vec3 ourColor;
in vec3 Normal;
in vec3 FragPos;

out vec4 FragColor;
uniform vec3 objectColor;


void main()
{

    FragColor = vec4(ourColor* objectColor,1.0f);
}   