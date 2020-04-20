# plain-text-table

## Transform HTML code into plain text

paragraph with borders
```html
<p all-borders>Oi, tudo bem?</p>
```
    +-------------------------------------------------------+
    |Oi, tudo bem?                                          |
    +-------------------------------------------------------+

paragraph with customizable borders
```html
<p border='x' border-bottom='.'>Oi, tudo bem?</p>
```
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    xOi, tudo bem?                                          x
    x.......................................................x

tables
```html
<tr text-center="">
    <td>Produto</td>
    <td width="auto">Valor</td>
    <td width="auto">Qtd.</td>
    <td width="auto">Total</td>
</tr>
<tr>
    <td> Refeição </td>
    <td text-right> R$ 39,90 </td>
    <td text-center> 0,243kg </td>
    <td text-right> R$ 9,70 </td>
</tr>
<tr>
    <td>Refrigerantes</td>
    <td text-right>R$ 4,50</td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td>Sucos</td>
    <td text-right></td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
</tr>
```
    --------------------------------------------------
             Produto         | Valor  | Qtd.  | Total 
    -------------------------+--------+-------+-------
    Refeição                 |R$ 39,90|0,243kg|R$ 9,70
    -------------------------+--------+-------+-------
    Refrigerantes            | R$ 4,50|       |       
    -------------------------+--------+-------+-------
    Sucos                    |        |       |       
    -------------------------+--------+-------+-------
                             |        |       |       
    -------------------------+--------+-------+-------
                             |        |       |       
    -------------------------+--------+-------+-------
                             |        |       |       
    --------------------------------------------------
