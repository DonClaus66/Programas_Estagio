int num = 12034;
int num_inv = 0;

int main()
{
    int aux_num = num;
    for (int i = 0; i < sizeof(int)*8; i++)
    {
        num_inv += aux_num & 1;
        aux_num = aux_num >> 1;
        if (!aux_num)
            break;
        num_inv << 1;
    }
    printf("%i\n", num);
    printf("%i\n", num_inv);
}