#version 330 core

in vec4 vertexColor; 
out vec4 FragColor;
  
uniform vec4 ourColor; // we set this variable in the OpenGL code.

void main()
{
    FragColor = vertexColor;
}   