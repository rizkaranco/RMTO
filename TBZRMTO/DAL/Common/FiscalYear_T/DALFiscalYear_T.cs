using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL

{
public partial class DALYear_T: DataLayerBase
{


public DALYear_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.BLLYear_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Output;
YearID_int.IsNullable = false;
YearID_int.Value = businessObject.YearID_int;
this.Command.Parameters.Add(YearID_int);

SqlParameter Year_nvc =new SqlParameter();
Year_nvc.ParameterName = "@Year_nvc";
Year_nvc.SqlDbType = SqlDbType.NVarChar;
Year_nvc.Direction = ParameterDirection.Input;
Year_nvc.IsNullable = false;
Year_nvc.Value = businessObject.Year_nvc;
this.Command.Parameters.Add(Year_nvc);

SqlParameter StartDate_nvc =new SqlParameter();
StartDate_nvc.ParameterName = "@StartDate_nvc";
StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
StartDate_nvc.Direction = ParameterDirection.Input;
StartDate_nvc.IsNullable = false;
StartDate_nvc.Value = businessObject.StartDate_nvc;
this.Command.Parameters.Add(StartDate_nvc);

SqlParameter EndDate_nvc =new SqlParameter();
EndDate_nvc.ParameterName = "@EndDate_nvc";
EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
EndDate_nvc.Direction = ParameterDirection.Input;
EndDate_nvc.IsNullable = false;
EndDate_nvc.Value = businessObject.EndDate_nvc;
this.Command.Parameters.Add(EndDate_nvc);

SqlParameter Description_nvc =new SqlParameter();
Description_nvc.ParameterName = "@Description_nvc";
Description_nvc.SqlDbType = SqlDbType.NText;
Description_nvc.Direction = ParameterDirection.Input;
Description_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.Description_nvc) ){
Description_nvc.Value = DBNull.Value;
}else{
Description_nvc.Value = businessObject.Description_nvc;
}
this.Command.Parameters.Add(Description_nvc);

SqlParameter CurrencyID_int =new SqlParameter();
CurrencyID_int.ParameterName = "@CurrencyID_int";
CurrencyID_int.SqlDbType = SqlDbType.Int;
CurrencyID_int.Direction = ParameterDirection.Input;
CurrencyID_int.IsNullable = false;
CurrencyID_int.Value = businessObject.CurrencyID_int;
this.Command.Parameters.Add(CurrencyID_int);

SqlParameter Default_bit =new SqlParameter();
Default_bit.ParameterName = "@Default_bit";
Default_bit.SqlDbType = SqlDbType.Bit;
Default_bit.Direction = ParameterDirection.Input;
Default_bit.IsNullable = false;
Default_bit.Value = businessObject.Default_bit;
this.Command.Parameters.Add(Default_bit);

SqlParameter SourceYearID_int =new SqlParameter();
SourceYearID_int.ParameterName = "@SourceFiscalYearID_int";
SourceYearID_int.SqlDbType = SqlDbType.Int;
SourceYearID_int.Direction = ParameterDirection.Input;
SourceYearID_int.IsNullable = true;
if (businessObject.SourceFiscalYearID_int.HasValue == false)
{
SourceYearID_int.Value = DBNull.Value;
}else{
    SourceYearID_int.Value = businessObject.SourceFiscalYearID_int;
}
this.Command.Parameters.Add(SourceYearID_int);

SqlParameter DataBase_nvc =new SqlParameter();
DataBase_nvc.ParameterName = "@DataBase_nvc";
DataBase_nvc.SqlDbType = SqlDbType.NVarChar;
DataBase_nvc.Direction = ParameterDirection.Input;
DataBase_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.DataBase_nvc) ){
DataBase_nvc.Value = DBNull.Value;
}else{
DataBase_nvc.Value = businessObject.DataBase_nvc;
}
this.Command.Parameters.Add(DataBase_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.YearID_int = (Int32)(this.Command.Parameters["@YearID_int"].Value); 

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void Update(HPS.BLL.BLLYear_T businessObject,HPS.BLL.BLLYear_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter Year_nvc =new SqlParameter();
Year_nvc.ParameterName = "@Year_nvc";
Year_nvc.SqlDbType = SqlDbType.NVarChar;
Year_nvc.Direction = ParameterDirection.Input;
Year_nvc.IsNullable = false;
Year_nvc.Value = businessObject.Year_nvc;
this.Command.Parameters.Add(Year_nvc);

SqlParameter StartDate_nvc =new SqlParameter();
StartDate_nvc.ParameterName = "@StartDate_nvc";
StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
StartDate_nvc.Direction = ParameterDirection.Input;
StartDate_nvc.IsNullable = false;
StartDate_nvc.Value = businessObject.StartDate_nvc;
this.Command.Parameters.Add(StartDate_nvc);

SqlParameter EndDate_nvc =new SqlParameter();
EndDate_nvc.ParameterName = "@EndDate_nvc";
EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
EndDate_nvc.Direction = ParameterDirection.Input;
EndDate_nvc.IsNullable = false;
EndDate_nvc.Value = businessObject.EndDate_nvc;
this.Command.Parameters.Add(EndDate_nvc);

SqlParameter Description_nvc =new SqlParameter();
Description_nvc.ParameterName = "@Description_nvc";
Description_nvc.SqlDbType = SqlDbType.NText;
Description_nvc.Direction = ParameterDirection.Input;
Description_nvc.IsNullable = false;
if(String.IsNullOrEmpty(businessObject.Description_nvc) ){
Description_nvc.Value = DBNull.Value;
}else{
Description_nvc.Value = businessObject.Description_nvc;
}
this.Command.Parameters.Add(Description_nvc);

SqlParameter CurrencyID_int =new SqlParameter();
CurrencyID_int.ParameterName = "@CurrencyID_int";
CurrencyID_int.SqlDbType = SqlDbType.Int;
CurrencyID_int.Direction = ParameterDirection.Input;
CurrencyID_int.IsNullable = true;
CurrencyID_int.Value = businessObject.CurrencyID_int;
this.Command.Parameters.Add(CurrencyID_int);

SqlParameter Default_bit =new SqlParameter();
Default_bit.ParameterName = "@Default_bit";
Default_bit.SqlDbType = SqlDbType.Bit;
Default_bit.Direction = ParameterDirection.Input;
Default_bit.IsNullable = false;
Default_bit.Value = businessObject.Default_bit;
this.Command.Parameters.Add(Default_bit);

SqlParameter SourceYearID_int =new SqlParameter();
SourceYearID_int.ParameterName = "@SourceFiscalYearID_int";
SourceYearID_int.SqlDbType = SqlDbType.Int;
SourceYearID_int.Direction = ParameterDirection.Input;
SourceYearID_int.IsNullable = false;
if (businessObject.SourceFiscalYearID_int.HasValue == false)
{
SourceYearID_int.Value = DBNull.Value;
}else{
    SourceYearID_int.Value = businessObject.SourceFiscalYearID_int;
}
this.Command.Parameters.Add(SourceYearID_int);

SqlParameter DataBase_nvc =new SqlParameter();
DataBase_nvc.ParameterName = "@DataBase_nvc";
DataBase_nvc.SqlDbType = SqlDbType.NVarChar;
DataBase_nvc.Direction = ParameterDirection.Input;
DataBase_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.DataBase_nvc) ){
DataBase_nvc.Value = DBNull.Value;
}else{
DataBase_nvc.Value = businessObject.DataBase_nvc;
}
this.Command.Parameters.Add(DataBase_nvc);


SqlParameter pk_YearID_int =new SqlParameter();
pk_YearID_int.ParameterName = "@pk_YearID_int";
pk_YearID_int.SqlDbType = SqlDbType.Int;
pk_YearID_int.Direction = ParameterDirection.Input;
pk_YearID_int.IsNullable = false;
pk_YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(pk_YearID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public List< HPS.BLL.BLLYear_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BLLYear_T> Result  =new  List< HPS.BLL.BLLYear_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset,String srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataTable dataTable)
{
    bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
    SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
    this.Command.CommandText = "[sp_Year_T_SelectAll]";
    this.Command.CommandType = CommandType.StoredProcedure;

    try{

    this.Command.Parameters.Clear();

    if(ControlConnection ){
    this.BeginTransaction();
    }

    sqlDataAdapter.Fill(dataTable);

    if(ControlConnection ){
    this.Commit();
    }}
    catch (System.Exception ex){
    if(ControlConnection ){
    this.RollBack();
    }
    throw ex;
    }
}

public HPS.BLL.BLLYear_T SelectByPrimaryKey(HPS.BLL.BLLYear_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Input;
YearID_int.IsNullable = false;
YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(YearID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.BLLYear_T businessObject=new HPS.BLL.BLLYear_T();
if(dataReader.Read()) {
PopulateBusinessObjectFromReader(businessObject, dataReader);
}else{
businessObject = null;
}

if(dataReader.IsClosed == false) {
dataReader.Close();
}


if(ControlConnection) {
this.Commit();
}
return businessObject;}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.BLLYear_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Input;
YearID_int.IsNullable = false;
YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(YearID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.BLLYear_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Input;
YearID_int.IsNullable = false;
YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(YearID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.BLLYear_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Input;
YearID_int.IsNullable = false;
YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(YearID_int);



if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}





public List< HPS.BLL.BLLYear_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[Year_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BLLYear_T> Result = new List< HPS.BLL.BLLYear_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName ,Object  value  , ref System.Data.DataSet dataset  ,String  srcTable  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Year_T]."+ fieldName + " = N" + "'" + Convert.ToString(value)+ "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref System.Data.DataSet dataset  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Year_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Year_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public List<HPS.BLL.BLLYear_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.BLLYear_T> Result= new List<HPS.BLL.BLLYear_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataSet dataset,String srcTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  ,ref System.Data.DataSet dataset ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataTable dataTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Year_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void Delete(HPS.BLL.BLLYear_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter YearID_int =new SqlParameter();
YearID_int.ParameterName = "@YearID_int";
YearID_int.SqlDbType = SqlDbType.Int;
YearID_int.Direction = ParameterDirection.Input;
YearID_int.IsNullable = false;
YearID_int.Value = businessObjectKey.YearID_int;
this.Command.Parameters.Add(YearID_int);


if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void DeleteByField(String fieldName,Object value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Year_T_DeleteByField]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
this.Command.Parameters.Add(new SqlParameter("@Value", value));

if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void PopulateBusinessObjectFromReader(  HPS.BLL.BLLYear_T businessObject,IDataReader dataReader){
try {
businessObject.YearID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.YearID_int.ToString()));
businessObject.Year_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.Year_nvc.ToString()));
businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.StartDate_nvc.ToString()));
businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.EndDate_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.Description_nvc.ToString())) == false) {
businessObject.Description_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.Description_nvc.ToString()));
}else{
businessObject.Description_nvc = String.Empty;
}

businessObject.CurrencyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.CurrencyID_int.ToString()));
businessObject.Default_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.Default_bit.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.SourceFiscalYearID_int.ToString())) == false) {
    businessObject.SourceFiscalYearID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.SourceFiscalYearID_int.ToString()));
}else{
    businessObject.SourceFiscalYearID_int = null;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.DataBase_nvc.ToString())) == false) {
businessObject.DataBase_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLYear_T.Year_TField.DataBase_nvc.ToString()));
}else{
businessObject.DataBase_nvc = String.Empty;
}

}
catch (System.Exception ex)
{
   dataReader.Close();
   throw ex;
}
}

public List< HPS.BLL.BLLYear_T> PopulateObjectsFromReader(IDataReader dataReader){
try {
List< HPS.BLL.BLLYear_T> list=new List< HPS.BLL.BLLYear_T>();
while (dataReader.Read()){
HPS.BLL.BLLYear_T businessObject =new HPS.BLL.BLLYear_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}
catch (System.Exception ex)
{
   dataReader.Close();
   throw ex;
}
}

}
} 