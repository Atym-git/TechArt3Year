


#ifndef VF_CUSTOM_SHADERGRAPH_FUNCTIONS
#define VF_CUSTOM_SHADERGRAPH_FUNCTIONS

float Normalize(float A)
{
    if (A > 1)
    {
        A = 1;
    }
    else if (A < 0)
    {
        A = 0;
    }
    return A;
}

#endif