#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

float near = 0.1; 
float far  = 100.0; 

void main()
{    
    FragColor = texture(texture1, TexCoords);

    float depth = gl_FragCoord.z;
    float ndc = depth * 2.0 - 1.0;
    float linearDepth = (2.0 * near * far) / (far + near - ndc * (far - near));
    float normalizedDepth = linearDepth / far; // Normalize to [0,1] range

    FragColor = vec4(vec3(normalizedDepth), 1.0f);
}