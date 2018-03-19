﻿/**
 * Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/rudi-krsoftware/open-retail
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace OpenRetail.Model
{
    [Table("m_setting_aplikasi")]
    public class SettingAplikasi
    {
        [ExplicitKey]
        public string setting_aplikasi_id { get; set; }
        public bool is_update_harga_jual_master_produk { get; set; }
        public bool is_stok_produk_boleh_minus { get; set; }
        public bool is_fokus_input_kolom_jumlah { get; set; }
        public bool is_tampilkan_keterangan_tambahan_item_jual { get; set; }
        public string keterangan_tambahan_item_jual { get; set; }
    }
}
