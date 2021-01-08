﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DAL;

namespace api.Migrations
{
    [DbContext(typeof(dataContext))]
    [Migration("20210108115624_drietables")]
    partial class drietables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("api.DAL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DatabaseRole")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IBAN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Interests")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Introduction")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KnownAs")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LookingFor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mobile")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("hospital_id")
                        .HasColumnType("int");

                    b.Property<string>("worked_in")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.DAL.data.Cardio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("air_circuit")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cannula_problems")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("cassette_id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("center_id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("clots")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("comment1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("comment2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("comment3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("comment4")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("comment5")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("conn_crack")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("contributor_id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("cp")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_ca")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_cp")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_hy")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_in")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_my")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_pda_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_pda_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_pda_3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_pda_4")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_ta_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_ta_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("cp_ta_3")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("date_death_followup")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("death_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("death_date_hours")
                        .HasColumnType("int");

                    b.Property<int>("death_date_minutes")
                        .HasColumnType("int");

                    b.Property<DateTime>("discharge")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("discharge_hours")
                        .HasColumnType("int");

                    b.Property<int>("discharge_minutes")
                        .HasColumnType("int");

                    b.Property<bool>("discharged_alive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("double_lumen")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("extubation")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("extubation_hours")
                        .HasColumnType("int");

                    b.Property<int>("extubation_minutes")
                        .HasColumnType("int");

                    b.Property<bool>("heat_malf")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo_ca")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo_di")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo_gi")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo_he")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hemo_su")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte[]>("hemodynamics")
                        .HasColumnType("longblob");

                    b.Property<int>("indication")
                        .HasColumnType("int");

                    b.Property<bool>("infect")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("infect_cu")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("infect_wb")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("last_followup")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("lldp")
                        .HasColumnType("int");

                    b.Property<int>("lldp_diam")
                        .HasColumnType("int");

                    b.Property<int>("lldp_length")
                        .HasColumnType("int");

                    b.Property<bool>("meta")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("meta_gl_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("meta_gl_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("meta_hy")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("meta_ph_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("meta_ph_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro_br")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro_ee")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro_he")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro_in")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("neuro_se")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("one_year_followup")
                        .HasColumnType("int");

                    b.Property<bool>("ox_failure")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("page_1_complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("page_2_complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("page_3_complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("page_4_complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("page_5_complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("patient_age")
                        .HasColumnType("int");

                    b.Property<int>("patient_gender")
                        .HasColumnType("int");

                    b.Property<bool>("percutaneous_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("percutaneous_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("percutaneous_3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("pulm")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("pulm_pn")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("pulm_pu")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("pump_malf")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("reason_cardiac")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("reason_cns")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("reason_infection")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("reason_liver")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("reason_other")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("reason_pulmonary")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("registry_id")
                        .HasColumnType("int");

                    b.Property<bool>("renal")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("renal_ca")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("renal_cr_1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("renal_cr_2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("renal_di")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("renal_he")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("selected_age")
                        .HasColumnType("int");

                    b.Property<int>("selected_arrest")
                        .HasColumnType("int");

                    b.Property<int>("selected_btt")
                        .HasColumnType("int");

                    b.Property<int>("selected_cannulation_site_1")
                        .HasColumnType("int");

                    b.Property<int>("selected_cannulation_site_2")
                        .HasColumnType("int");

                    b.Property<int>("selected_cannulation_site_3")
                        .HasColumnType("int");

                    b.Property<int>("selected_discharge_location")
                        .HasColumnType("int");

                    b.Property<int>("selected_fac")
                        .HasColumnType("int");

                    b.Property<double?>("selected_height")
                        .HasColumnType("double");

                    b.Property<int>("selected_intubated")
                        .HasColumnType("int");

                    b.Property<int>("selected_length_1")
                        .HasColumnType("int");

                    b.Property<int>("selected_length_2")
                        .HasColumnType("int");

                    b.Property<int>("selected_length_3")
                        .HasColumnType("int");

                    b.Property<int>("selected_reason")
                        .HasColumnType("int");

                    b.Property<int>("selected_reason_death")
                        .HasColumnType("int");

                    b.Property<int>("selected_repair")
                        .HasColumnType("int");

                    b.Property<int>("selected_size_1")
                        .HasColumnType("int");

                    b.Property<int>("selected_size_2")
                        .HasColumnType("int");

                    b.Property<int>("selected_size_3")
                        .HasColumnType("int");

                    b.Property<int>("selected_vv_size")
                        .HasColumnType("int");

                    b.Property<double?>("selected_weight")
                        .HasColumnType("double");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("start_hour")
                        .HasColumnType("int");

                    b.Property<int>("start_min")
                        .HasColumnType("int");

                    b.Property<DateTime>("stop")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("stop_hour")
                        .HasColumnType("int");

                    b.Property<int>("stop_min")
                        .HasColumnType("int");

                    b.Property<int>("support_mode")
                        .HasColumnType("int");

                    b.Property<string>("support_mode_other")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("time_supported")
                        .HasColumnType("int");

                    b.Property<bool>("tub_rupture")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Cardios");
                });

            modelBuilder.Entity("api.DAL.data.hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("center_id")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("fax")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pobox")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("street")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });
#pragma warning restore 612, 618
        }
    }
}