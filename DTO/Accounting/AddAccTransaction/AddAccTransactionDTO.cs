
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace PayaG4.SDK.DTO.AccTransaction;
public class AddAccTransactionDTO
{
    public List<AccTransactionItemDTO> AccTransactionItems { get; set; }
    public int DocumentCategoryCode { get; set; }
    public DateTime AccDate { get; set; }
}

