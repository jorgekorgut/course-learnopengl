#version 330 core
layout (location = 0) in vec3 aPos;
  
out vec4 vertexColor; 

uniform vec4 offset;

void main()
{
    vec3 newPos = aPos;
    newPos.y = -1.0 * aPos.y;

    newPos += offset.xyz;

    gl_Position = vec4(newPos, 1.0); 
    vertexColor = gl_Position; 
}